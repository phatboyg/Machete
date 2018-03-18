namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class TestSegmentMap :
        X12SegmentMap<TestSegment, X12Entity>
    {
        public TestSegmentMap()
        {
            Id = "MTS";
            Name = "Test";
            
            Value(x => x.Field1, 1);
            Value(x => x.Field2, 2);
            Entity(x => x.Field3, 3);
            Entity(x => x.Field4, 4);
            Value(x => x.Field5, 5);
        }
    }
}