namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopDED_820 :
        X12Layout
    {
        Segment<DED> Deductions { get; }
    }
}