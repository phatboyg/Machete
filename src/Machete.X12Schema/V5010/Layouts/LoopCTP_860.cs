namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopCTP_860 :
        X12Layout
    {
        Segment<CTP> PricingInformation { get; }
        
        Segment<CUR> Currency { get; }
    }
}