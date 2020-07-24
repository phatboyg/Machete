namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAMT_820 :
        X12Layout
    {
        Segment<AMT> MonetaryAmount { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
    }
}