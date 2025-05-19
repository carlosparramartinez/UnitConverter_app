namespace UnitConverterApp.Models
{
    public class TemperatureModel
    {
        public double Value { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double Result { get; set; }
        public List<string> Units { get; set; } = new List<string> { "Celsius", "Fahrenheit", "Kelvin" };
    }
}