namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0330_947 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        LayoutList<Loop0331_947> Loop0331 { get; }
    }
}