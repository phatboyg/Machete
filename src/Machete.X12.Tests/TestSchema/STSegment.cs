namespace Machete.X12.Tests.TestSchema
{
    public interface STSegment :
        X12Segment
    {
        Value<string> IdentifierCode { get; }
        
        Value<string> ControlNumber { get; }
    }
}