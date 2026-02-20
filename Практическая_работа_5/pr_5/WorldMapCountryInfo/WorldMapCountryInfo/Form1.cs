using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Linq;


namespace WorldMapCountryInfo
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        private readonly GMapOverlay _markersOverlay;
        private readonly Dictionary<string, PointLatLng> _countryCenters;
        private string _googleApiKey = "";

        private readonly string _apiKeyPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "WorldMapCountryInfo",
            "google_api_key.txt"
        );

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _markersOverlay = new GMapOverlay("countries");
            _countryCenters = new Dictionary<string, PointLatLng>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadApiKey();

            if (string.IsNullOrWhiteSpace(_googleApiKey))
            {
                PromptForApiKey();
            }

            if (!string.IsNullOrWhiteSpace(_googleApiKey))
            {
                // Настройка Google Maps
                GMapProviders.GoogleMap.ApiKey = _googleApiKey;
                gMapControl.MapProvider = GMapProviders.GoogleMap;
            }
            else
            {
                MessageBox.Show(
                    "API-ключ Google Maps не указан.\n" +
                    "Перезапустите приложение и введите ключ при запуске.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Application.Exit();
                return;
            }

            gMapControl.Position = new PointLatLng(20, 0);
            gMapControl.MinZoom = 2;
            gMapControl.MaxZoom = 18;
            gMapControl.Zoom = 2;

            gMapControl.Overlays.Add(_markersOverlay);

            _countryCenters["RU"] = new PointLatLng(61.5240, 105.3188);
            _countryCenters["US"] = new PointLatLng(37.0902, -95.7129);
            _countryCenters["CN"] = new PointLatLng(35.8617, 104.1954);
            _countryCenters["DE"] = new PointLatLng(51.1657, 10.4515);
            _countryCenters["FR"] = new PointLatLng(46.2276, 2.2137);
            _countryCenters["JP"] = new PointLatLng(36.2048, 138.2529);
            _countryCenters["BR"] = new PointLatLng(-14.2350, -51.9253);
            _countryCenters["IN"] = new PointLatLng(20.5937, 78.9629);

            foreach (var kvp in _countryCenters)
            {
                var marker = new GMarkerGoogle(kvp.Value, GMarkerGoogleType.blue_dot);
                marker.ToolTipText = GetCountryNameByCode(kvp.Key);
                marker.Tag = kvp.Key;
                _markersOverlay.Markers.Add(marker);
            }

            gMapControl.OnMarkerClick += gMapControl_OnMarkerClick;
        }

        private void LoadApiKey()
        {
            try
            {
                if (File.Exists(_apiKeyPath))
                {
                    _googleApiKey = File.ReadAllText(_apiKeyPath).Trim();
                }
            }
            catch { /* игнорируем ошибки */ }
        }

        private void PromptForApiKey()
        {
            using (var form = new Form())
            {
                form.Width = 500;
                form.Height = 200;
                form.Text = "Введите Google Maps API-ключ";

                var label = new Label
                {
                    Left = 10,
                    Top = 10,
                    Width = 480,
                    Text = "Введите свой Google Maps API-ключ:\n" +
                           "(получить можно в Google Cloud Console → APIs & Services → Credentials)"
                };

                var textBox = new TextBox
                {
                    Left = 10,
                    Top = 60,
                    Width = 460,
                    PasswordChar = '*'
                };

                var buttonOk = new Button
                {
                    Text = "OK",
                    Left = 380,
                    Top = 100,
                    Width = 80
                };
                buttonOk.Click += (s, e) =>
                {
                    _googleApiKey = textBox.Text.Trim();
                    if (!string.IsNullOrEmpty(_googleApiKey))
                    {
                        try
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(_apiKeyPath));
                            File.WriteAllText(_apiKeyPath, _googleApiKey);
                        }
                        catch { /* игнор */ }
                    }
                    form.Close();
                };

                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(buttonOk);
                form.ShowDialog();
            }
        }

        private string GetCountryNameByCode(string code)
        {
            var names = new Dictionary<string, string>
            {
                ["RU"] = "Россия",
                ["US"] = "США",
                ["CN"] = "Китай",
                ["DE"] = "Германия",
                ["FR"] = "Франция",
                ["JP"] = "Япония",
                ["BR"] = "Бразилия",
                ["IN"] = "Индия"
            };
            return names.TryGetValue(code, out var name) ? name : code;
        }

        private async void gMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var countryCode = item.Tag?.ToString();
            if (string.IsNullOrEmpty(countryCode)) return;

            try
            {
                await LoadCountryInfoAsync(countryCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCountryInfoAsync(string countryCode)
        {
            var url = $"https://restcountries.com/v3.1/alpha/{countryCode}";
            var response = await _httpClient.GetStringAsync(url);
            var countries = JArray.Parse(response);
            var country = countries[0];

            var name = country["translations"]?["rus"]?["official"]?.ToString() ??
                        country["name"]?["common"]?.ToString() ?? "Неизвестно";

            var flagUrl = country["flags"]?["png"]?.ToString();
            var population = country["population"]?.ToObject<long>() ?? 0;

            string currencyStr = "—";
            var currencies = country["currencies"];

            if (currencies != null && currencies.Type == JTokenType.Object)
            {
                foreach (var token in currencies)
                {
                    if (token is JProperty prop)
                    {
                        var curName = prop.Value["name"]?.ToString() ?? "—";
                        var symbol = prop.Value["symbol"]?.ToString() ?? "";
                        currencyStr = $"{curName} ({symbol})";
                        break;
                    }
                }
            }

            lblCountryName.Text = name;
            lblCurrencyValue.Text = currencyStr;
            lblPopulationValue.Text = FormatNumber(population);

            if (!string.IsNullOrEmpty(flagUrl))
            {
                Stream stream = null;
                try
                {
                    stream = await _httpClient.GetStreamAsync(flagUrl);
                    var image = Image.FromStream(stream);
                    pictureBoxFlag.Image = image;
                }
                catch
                {
                    pictureBoxFlag.Image = null;
                }
                finally
                {
                    stream?.Dispose();
                }
            }
            else
            {
                pictureBoxFlag.Image = null;
            }
        }

        private string FormatNumber(long number)
        {
            return number.ToString("N0", System.Globalization.CultureInfo.CreateSpecificCulture("ru-RU"));
        }
    }
}
