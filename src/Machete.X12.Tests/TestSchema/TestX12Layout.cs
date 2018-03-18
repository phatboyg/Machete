namespace Machete.X12.Tests.TestSchema
{
    public interface TestX12Layout :
        X12Layout
    {
        Segment<ISASegment> InterchangeControlHeader { get; }
        
        Segment<GSSegment> FunctionalGroupHeader { get; }
        
        Segment<STSegment> TransactionSetHeader { get; }
        
        Segment<TestSegment> TestSegment { get; }
        
        Segment<SESegment> TransactionSetTrailer { get; }
        
        Segment<GESegment> FunctionalGroupTrailer { get; }
        
        Segment<IEASegment> InterchangeControlTrailer { get; }
    }
}