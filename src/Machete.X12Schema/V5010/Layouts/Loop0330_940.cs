namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0330_940 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
        
        LayoutList<Loop0331_940> Loop0331 { get; }
        
        LayoutList<Loop0332_940> Loop0332 { get; }
    }
}