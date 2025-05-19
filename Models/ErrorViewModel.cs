namespace UnitConverter_App.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
public class ConversionModel
{
    public double Value { get; set; }
    public string FromUnit { get; set; }
    public string ToUnit { get; set; }
    public double Result { get; set; }
}