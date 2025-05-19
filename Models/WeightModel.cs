using System.Collections.Generic;

namespace UnitConverterApp.Models
{
    public class WeightModel
    {
        public double Value { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double Result { get; set; }

        public List<string> Units { get; set; } = new List<string>
        {
            "mg", "g", "kg", "lb", "oz", "ton"
        };
    }
}