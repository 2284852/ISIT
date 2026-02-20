using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace prakt_1
{
    public partial class Form1 : Form
    {
        private string yandexApiKey = "dict.1.1.20260127T153604Z.adb9b7101f2092e6.97fd933f857d4c0f3db16d5fea083a6bad38c467";
        private readonly HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            txtResult.ReadOnly = true;
            txtResult.Font = new System.Drawing.Font("Consolas", 9);
        }
        private bool IsRussian(string word)
        {
            return Regex.IsMatch(word, @"[а-яА-ЯёЁ]");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim();
            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Введите слово для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSearch.Enabled = false;
            txtResult.Text = "🔍 Поиск...\n";
            Application.DoEvents();

            try
            {
                if (IsRussian(word))
                {
                    if (string.IsNullOrEmpty(yandexApiKey) || yandexApiKey == "ваш_реальный_API_ключ_здесь")
                    {
                        txtResult.Text = "❌ Не указан API-ключ Yandex. Введите его в коде (строка: private string yandexApiKey = \"...\";)";
                        return;
                    }
                    await SearchYandexAsync(word);
                }
                else
                {
                    await SearchDictionaryApiAsync(word);
                }
            }
            catch (Exception ex)
            {
                txtResult.Text = $"❌ Ошибка: {ex.Message}";
            }
            finally
            {
                btnSearch.Enabled = true;
            }
        }

        private async Task SearchDictionaryApiAsync(string word)
        {
            var url = $"https://api.dictionaryapi.dev/api/v2/entries/en/{word}";
            var json = await httpClient.GetStringAsync(url);
            var data = JArray.Parse(json);

            var result = new System.Text.StringBuilder();
            result.AppendLine($"🔤 Слово: {word}");
            result.AppendLine(new string('=', 50));

            foreach (var entry in data)
            {
                var phonetic = entry["phonetic"]?.ToString() ?? "";
                if (!string.IsNullOrEmpty(phonetic))
                    result.AppendLine($"🔊 Транскрипция: /{phonetic}/");

                foreach (var meaning in entry["meanings"])
                {
                    var partOfSpeech = meaning["partOfSpeech"]?.ToString() ?? "—";
                    result.AppendLine($"\n📌 Часть речи: {partOfSpeech}");

                    int defIndex = 1;
                    foreach (var def in meaning["definitions"])
                    {
                        result.AppendLine($"{defIndex}. {def["definition"]}");
                        if (def["example"] != null)
                            result.AppendLine($"   💬 Пример: {def["example"]}");
                        defIndex++;
                    }

                    var synonyms = meaning["synonyms"];
                    if (synonyms != null && synonyms.HasValues)
                        result.AppendLine($"   ↔ Синонимы: {string.Join(", ", synonyms)}");

                    var antonyms = meaning["antonyms"];
                    if (antonyms != null && antonyms.HasValues)
                        result.AppendLine($"   ↕ Антонимы: {string.Join(", ", antonyms)}");
                }
            }

            txtResult.Text = result.ToString();
        }

        private async Task SearchYandexAsync(string word)
        {
            var url = $"https://dictionary.yandex.net/api/v1/dicservice.json/lookup?key={yandexApiKey}&lang=ru-en&text={Uri.EscapeDataString(word)}";
            var json = await httpClient.GetStringAsync(url);
            var data = JObject.Parse(json);

            var defs = data["def"];
            if (defs == null || !defs.HasValues)
            {
                txtResult.Text = "❌ Слово не найдено в словаре.";
                return;
            }

            var result = new System.Text.StringBuilder();
            result.AppendLine($"🔤 Слово: {word}");
            result.AppendLine(new string('=', 50));

            foreach (var def in defs)
            {
                var pos = def["pos"]?.ToString() ?? "—";
                result.AppendLine($"\n📌 Часть речи: {pos}");

                foreach (var tr in def["tr"])
                {
                    var translation = tr["text"]?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(translation))
                        result.AppendLine($"→ Перевод: {translation}");

                    var examples = tr["ex"];
                    if (examples != null)
                    {
                        foreach (var ex in examples.Take(2))
                        {
                            var text = ex["text"]?.ToString();
                            var trText = ex["tr"]?[0]?["text"]?.ToString();
                            if (!string.IsNullOrEmpty(text))
                                result.AppendLine($"   💬 Пример: {text}{(trText != null ? $" → {trText}" : "")}");
                        }
                    }
                }
            }

            txtResult.Text = result.ToString();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWord.Clear();
            txtResult.Clear();
            txtWord.Focus();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                Clipboard.SetText(txtResult.Text);
                MessageBox.Show("Результат скопирован в буфер обмена.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет данных для копирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
