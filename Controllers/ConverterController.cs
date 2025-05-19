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

        [HttpPost]
        public IActionResult Length(ConversionModel model)
        {
            // Lógica de conversión sencilla (puedes cambiarla)
            model.Result = ConvertLength(model.Value, model.FromUnit, model.ToUnit);
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
    }
}