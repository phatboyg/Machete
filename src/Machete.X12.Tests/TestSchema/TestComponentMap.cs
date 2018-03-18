namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class TestComponentMap :
        X12ComponentMap<TestComponent, X12Entity>
    {
        public TestComponentMap()
        {
            Value(x => x.Component1, 0, x => x.MinLength(1).MaxLength(50));
            Value(x => x.Component2, 1, x => x.MinLength(1).MaxLength(20));
        }
    }
}