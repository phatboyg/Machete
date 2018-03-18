namespace Machete.X12.Tests.TestSchema
{
    public interface IEASegment :
        X12Segment
    {
        Value<int> FunctionalGroupCount { get; }
        
        Value<int> ControlNumber { get; }
    }
}