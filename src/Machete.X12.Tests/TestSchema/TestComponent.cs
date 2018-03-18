namespace Machete.X12.Tests.TestSchema
{
    public interface TestComponent :
        X12Component
    {
        Value<string> Component1 { get; }
        
        Value<int> Component2 { get; }
    }
}