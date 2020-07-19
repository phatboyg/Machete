namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopN9 :
        X12Layout
    {
        Segment<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<MSG> MessageText { get; }
    }
}