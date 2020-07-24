namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_2_820 :
        X12Layout
    {
        Segment<N1> Name { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        LayoutList<LoopEMS_820> LoopEMS { get; }
    }
}