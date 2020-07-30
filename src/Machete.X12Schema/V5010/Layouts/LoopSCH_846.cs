namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSCH_846 :
        X12Layout
    {
        Segment<SCH> LineItemSchedule { get; }
        Segment<MEA> Measurements { get; }
    }
}