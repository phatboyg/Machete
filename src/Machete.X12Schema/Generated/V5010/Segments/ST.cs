namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ST :
        X12Segment
    {
        Value<string> IdentifierCode { get; }
        
        Value<string> ControlNumber { get; }
    }
}