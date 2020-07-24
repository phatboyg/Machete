namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopTXP_820 :
        X12Layout
    {
        Segment<TXP> TaxPayment { get; }
        
        SegmentList<TXI> TaxInformation { get; }
    }
}