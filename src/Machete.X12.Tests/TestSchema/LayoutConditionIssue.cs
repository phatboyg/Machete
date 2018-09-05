namespace Machete.X12.Tests.TestSchema
{
    public interface LayoutCondition1Issue :
        X12Layout
    {
        Segment<ISASegment> InterchangeControlHeader { get; }
        
        Segment<GSSegment> FunctionalGroupHeader { get; }
        
        Segment<STSegment> TransactionSetHeader { get; }
        
        Segment<PERSegment> BusinessContactInformation { get; }
        
        Segment<PERSegment> TechnicalContactInformation { get; }
        
        Segment<PERSegment> PayerWebsite { get; }
        
        Segment<SESegment> TransactionSetTrailer { get; }
        
        Segment<GESegment> FunctionalGroupTrailer { get; }
        
        Segment<IEASegment> InterchangeControlTrailer { get; }
    }
}