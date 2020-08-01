namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPD_865 :
        X12Layout
    {
        Segment<PD> PricingData { get; }
        
        SegmentList<PDD> PricingDataDetails { get; }
    }
}