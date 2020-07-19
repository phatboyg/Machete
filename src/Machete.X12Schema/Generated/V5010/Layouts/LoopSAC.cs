namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopSAC :
        X12Layout
    {
        Segment<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
    }
}