namespace Machete.X12.Tests.TestSchema
{
    public interface TestSegment :
        X12Segment
    {
        Value<string> Field1 { get; }
        
        ValueList<string> Field2 { get; }
        
        ValueList<TestComponent> Field3 { get; }
        
        Value<TestComponent> Field4 { get; }
        
        Value<int> Field5 { get; }
    }
}