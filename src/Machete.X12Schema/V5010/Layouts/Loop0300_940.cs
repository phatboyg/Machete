namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0300_940 :
        X12Layout
    {
        Segment<LX> TransactionSetLineNumber { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<G62> DateOrTime { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        LayoutList<Loop0310_940> Loop0310 { get; }
    }
}