using Microsoft.AspNetCore.Mvc;
using UnitConverterApp.Models;

namespace UnitConverterApp.Controllers
{
    public class ConverterController : Controller
    {
        [HttpGet]
        public IActionResult Length()
        {
            return View(new ConversionModel()); // <-- inicializa el modelo para evitar NullReferenceException
        }
        [HttpGet]
        public IActionResult Weight()
        {
            return View(new WeightModel());
        }
        [HttpGet]
        public IActionResult Temperature()
        {
            return View(new TemperatureModel());
        }
        [HttpPost]
        public IActionResult Length(ConversionModel model)
        {
            // Lógica de conversión sencilla (puedes cambiarla)
            model.Result = ConvertLength(model.Value, model.FromUnit, model.ToUnit);
            model.Units = new List<string> { "mm", "cm", "m", "km", "in", "ft", "yd", "mi"};
            return View(model);
        }
        [HttpPost]
        public IActionResult Temperature(TemperatureModel model)
        {
            model.Result = ConvertTemperature(model.Value, model.FromUnit, model.ToUnit);
            model.Units = new List<string> { "Celsius", "Fahrenheit", "Kelvin" };
            return View(model);
        }
        [HttpPost]
        public IActionResult Weight(WeightModel model)
        {
            model.Result = ConvertWeight(model.Value, model.FromUnit, model.ToUnit);
            model.Units = new List<string> { "mg", "g", "kg", "lb", "oz", "ton" };
            return View(model);
        }
        private double ConvertLength(double value, string from, string to)
        {
            var toMeters = from.ToLower() switch
            {
                "mm" => value / 1000,
                "cm" => value / 100,
                "m" => value,
                "km" => value * 1000,
                "in" => value * 0.0254,
                "ft" => value * 0.3048,
                "yd" => value * 0.9144,
                "mi" => value * 1609.34,
                _ => value
            };

            return to.ToLower() switch
            {
                "mm" => toMeters * 1000,
                "cm" => toMeters * 100,
                "m" => toMeters,
                "km" => toMeters / 1000,
                "in" => toMeters / 0.0254,
                "ft" => toMeters / 0.3048,
                "yd" => toMeters / 0.9144,
                "mi" => toMeters / 1609.34,
                _ => toMeters
            };
        }
        private double ConvertWeight(double value, string fromUnit, string toUnit)
        {
            var toKg = new Dictionary<string, double>
            {
                { "mg", 0.000001 },
                { "g", 0.001 },
                { "kg", 1 },
                { "lb", 0.453592 },
                { "oz", 0.0283495 },
                { "ton", 1000 }
            };

            if (!toKg.ContainsKey(fromUnit) || !toKg.ContainsKey(toUnit))
                return 0;

            double valueInKg = value * toKg[fromUnit];
            return valueInKg / toKg[toUnit];
        }

        private double ConvertTemperature(double value, string from, string to)
        {
            if (from == to) return value;

            double celsius = from switch
            {
                "Celsius" => value,
                "Fahrenheit" => (value - 32) * 5 / 9,
                "Kelvin" => value - 273.15,
                _ => value
            };

            return to switch
            {
                "Celsius" => celsius,
                "Fahrenheit" => (celsius * 9 / 5) + 32,
                "Kelvin" => celsius + 273.15,
                _ => celsius
            };
        }
    }
}