namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0310_940 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        LayoutList<LoopN1_940> LoopN1 { get; }
        
        SegmentList<LH2> HazardousClassificationInformation { get; }
        
        SegmentList<LHR> HazardousMaterialIdentifyingReferenceNumbers { get; }
        
        SegmentList<LH6> HazardousCertification { get; }
        
        LayoutList<Loop0320_940> Loop0320 { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<Loop0330_940> Loop0330 { get; }
        
        LayoutList<Loop0340_940> Loop0340 { get; }
    }
}