namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSAC_855 :
        X12Layout
    {
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        Segment<CUR> Currency { get; }
    }
}