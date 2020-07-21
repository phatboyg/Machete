namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2100C_277 :
        X12Layout
    {
        SegmentList<NM1> ServiceProvider { get; }
    }
}