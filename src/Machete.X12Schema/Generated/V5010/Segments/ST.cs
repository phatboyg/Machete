namespace Machete.X12.Schema.Segments
{
    public interface ST :
        X12Segment
    {
        Value<string> IdentifierCode { get; }
        
        Value<string> ControlNumber { get; }
    }
}