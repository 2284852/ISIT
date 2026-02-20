using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherExpertSystem
{
    public partial class Form1 : Form
    {
        private class WeatherRecord
        {
            public string City { get; set; }
            public double Temperature { get; set; }
            public double FeelsLike { get; set; }
            public int Humidity { get; set; }
            public double WindSpeed { get; set; }
            public int Pressure { get; set; }
            public double Precipitation { get; set; }
            public string State { get; set; }

            public WeatherRecord(string city, double temperature, double feelsLike, int humidity,
                double windSpeed, int pressure, double precipitation, string state)
            {
                City = city;
                Temperature = temperature;
                FeelsLike = feelsLike;
                Humidity = humidity;
                WindSpeed = windSpeed;
                Pressure = pressure;
                Precipitation = precipitation;
                State = state;
            }
        }

        private readonly List<WeatherRecord> _knowledgeBase;

        public Form1()
        {
            InitializeComponent();

            _knowledgeBase = new List<WeatherRecord>
            {
                new WeatherRecord("Макеевка", -7, -7, 60, 5, 1013, 0.0, "Ясно"),
                new WeatherRecord("Донецк", -5, -6, 65, 7, 1012, 0.0, "Ясно"),
                new WeatherRecord("Ростов", 0, -2, 70, 10, 1015, 0.5, "Облачно"),
                new WeatherRecord("Москва", -10, -12, 80, 3, 1008, 0.0, "Снег"),
                new WeatherRecord("Санкт-Петербург", -8, -10, 75, 8, 1010, 1.2, "Дождь")
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCity.DataSource = new List<string> { "Макеевка", "Донецк", "Ростов", "Москва", "Санкт-Петербург" };
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCity = cmbCity.SelectedItem.ToString();
                WeatherRecord record = null;
                foreach (var r in _knowledgeBase)
                {
                    if (r.City == selectedCity)
                    {
                        record = r;
                        break;
                    }
                }

                if (record == null) return;

                // Очистка
                ClearLabels();

                // Заполнение
                lblCityValue.Text = record.City;
                lblTempValue.Text = record.Temperature.ToString("F1") + "°C";
                lblFeelsLikeValue.Text = record.FeelsLike.ToString("F1") + "°C";
                lblHumidityValue.Text = record.Humidity + "%";
                lblWindValue.Text = record.WindSpeed.ToString("F1") + " м/с";
                lblPressureValue.Text = record.Pressure + " гПа";
                lblPrecipitationValue.Text = record.Precipitation.ToString("F1") + " мм";
                lblStateValue.Text = record.State;

                // Оценки
                string tempAssess = EvaluateTemperature(record.Temperature);
                string windAssess = EvaluateWind(record.WindSpeed);
                string precipAssess = EvaluatePrecipitation(record.Precipitation);
                string humidAssess = EvaluateHumidity(record.Humidity);

                lblTempAssessmentValue.Text = tempAssess;
                lblWindAssessmentValue.Text = windAssess;
                lblPrecipitationAssessmentValue.Text = precipAssess;
                lblHumidityAssessmentValue.Text = humidAssess;

                // Цветовая индикация
                SetAssessmentColor(lblTempAssessmentValue, tempAssess);
                SetAssessmentColor(lblWindAssessmentValue, windAssess);
                SetAssessmentColor(lblPrecipitationAssessmentValue, precipAssess);
                SetAssessmentColor(lblHumidityAssessmentValue, humidAssess);

                lblLastUpdated.Text = "Обновлено: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearLabels()
        {
            lblCityValue.Text = "";
            lblTempValue.Text = "";
            lblFeelsLikeValue.Text = "";
            lblHumidityValue.Text = "";
            lblWindValue.Text = "";
            lblPressureValue.Text = "";
            lblPrecipitationValue.Text = "";
            lblStateValue.Text = "";
            lblTempAssessmentValue.Text = "";
            lblWindAssessmentValue.Text = "";
            lblPrecipitationAssessmentValue.Text = "";
            lblHumidityAssessmentValue.Text = "";
        }

        private string EvaluateTemperature(double temp)
        {
            if (temp < -10) return "Очень холодно";
            if (temp < 0) return "Холодно";
            if (temp < 15) return "Прохладно";
            return "Тепло";
        }

        private string EvaluateWind(double wind)
        {
            if (wind < 5) return "Слабый";
            if (wind < 15) return "Умеренный";
            return "Сильный";
        }

        private string EvaluatePrecipitation(double precip)
        {
            if (precip == 0) return "Нет или слабые";
            if (precip <= 5) return "Умеренные";
            return "Сильные";
        }

        private string EvaluateHumidity(int humidity)
        {
            if (humidity < 40) return "Низкая";
            if (humidity <= 70) return "Нормальная";
            return "Высокая";
        }

        private void SetAssessmentColor(Label label, string assessment)
        {
            if (assessment.Contains("холод"))
                label.ForeColor = Color.FromArgb(0, 112, 192); // Синий
            else if (assessment.Contains("Тепло"))
                label.ForeColor = Color.FromArgb(255, 165, 0); // Оранжевый
            else if (assessment.Contains("Сильн"))
                label.ForeColor = Color.FromArgb(192, 0, 0); // Красный
            else
                label.ForeColor = Color.Black;
        }
    }
}
