namespace Machete.X12.Tests.TestSchema
{
    public interface LayoutCondition2Issue :
        X12Layout
    {
        Segment<ISASegment> InterchangeControlHeader { get; }
        
        Segment<GSSegment> FunctionalGroupHeader { get; }
        
        Segment<STSegment> TransactionSetHeader { get; }
        
        Segment<PERSegment> BusinessContactInformation { get; }
        
        SegmentList<PERSegment> TechnicalContactInformation { get; }
        
        Segment<SESegment> TransactionSetTrailer { get; }
        
        Segment<GESegment> FunctionalGroupTrailer { get; }
        
        Segment<IEASegment> InterchangeControlTrailer { get; }
    }
}