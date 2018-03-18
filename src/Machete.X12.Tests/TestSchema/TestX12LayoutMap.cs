namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class TestX12LayoutMap :
        X12LayoutMap<TestX12Layout, X12Entity>
    {
        public TestX12LayoutMap()
        {
            Id = "MT1";
            Name = "Test";
            
            Segment(x => x.InterchangeControlHeader, 0);
            Segment(x => x.FunctionalGroupHeader, 1);
            Segment(x => x.TransactionSetHeader, 2, x => x.IsRequired());
            Segment(x => x.TestSegment, 3, x => x.IsRequired());
            Segment(x => x.TransactionSetTrailer, 4);
            Segment(x => x.FunctionalGroupTrailer, 5);
            Segment(x => x.InterchangeControlTrailer, 6);
        }
    }
}