namespace UnitConverterApp.Models
{
    public class ConversionModel
    {
        public double Value { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double Result { get; set; }
       public List<string> Units { get; set; } = new List<string>
        {
            "mm", "cm", "m", "km", "in", "ft","yd", "mi"
        };
    }
}