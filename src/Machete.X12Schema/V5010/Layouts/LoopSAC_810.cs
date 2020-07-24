namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSAC_810 :
        X12Layout
    {
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
    }
}