namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2200B_277ACK :
        X12Layout
    {
        Segment<TRN> ApplicationTraceIdentifier { get; }
        
        SegmentList<STC> StatusInformation { get; }
        
        Segment<QTY> TotalAcceptedQuantity { get; }
        
        Segment<QTY> TotalRejectedQuantity { get; }
        
        Segment<AMT> TotalAcceptedAmount { get; }
        
        Segment<AMT> TotalRejectedAmount { get; }
    }
}