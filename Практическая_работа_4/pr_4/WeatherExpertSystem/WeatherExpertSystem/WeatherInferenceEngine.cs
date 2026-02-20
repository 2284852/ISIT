using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExpertSystem
{
    public static class WeatherInferenceEngine
    {
        public static string EvaluateTemperature(double temp)
        {
            if (temp < -10) return "Очень холодно";
            if (temp < 0) return "Холодно";
            if (temp < 15) return "Прохладно";
            return "Тепло";
        }

        public static string EvaluateWind(double wind)
        {
            if (wind < 5) return "Слабый";
            if (wind < 15) return "Умеренный";
            return "Сильный";
        }

        public static string EvaluatePrecipitation(double precip)
        {
            if (precip == 0) return "Нет или слабые";
            if (precip <= 5) return "Умеренные";
            return "Сильные";
        }

        public static string EvaluateHumidity(int humidity)
        {
            if (humidity < 40) return "Низкая";
            if (humidity <= 70) return "Нормальная";
            return "Высокая";
        }
    }
}
