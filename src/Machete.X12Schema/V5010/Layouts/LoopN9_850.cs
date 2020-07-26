namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN9_850 :
        X12Layout
    {
        Segment<N9> ReferenceIdentification { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        SegmentList<MSG> MessageText { get; }
    }
}