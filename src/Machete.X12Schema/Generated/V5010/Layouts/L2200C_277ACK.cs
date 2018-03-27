namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2200C_277ACK :
        X12Layout
    {
        Segment<TRN> ProviderOfServiceInformationTraceIdentifier { get; }
        
        SegmentList<STC> StatusInformation { get; }
        
        SegmentList<REF> SecondaryIdentifier { get; }
        
        Segment<QTY> TotalAcceptedQuantity { get; }
        
        Segment<QTY> TotalRejectedQuantity { get; }
        
        Segment<AMT> TotalAcceptedAmount { get; }
        
        Segment<AMT> TotalRejectedAmount { get; }
    }
}