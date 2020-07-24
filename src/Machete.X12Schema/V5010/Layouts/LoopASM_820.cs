namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopASM_820 :
        X12Layout
    {
        Segment<AMT> MonetaryAmount { get; }
        
        Segment<ADX> Adjustment { get; }
    }
}