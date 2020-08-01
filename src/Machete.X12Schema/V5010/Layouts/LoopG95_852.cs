namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopG95_852 : 
        X12Layout
    {
        Segment<G95> PerformanceRequirements { get; }
        
        SegmentList<DTM> DateOrTimeReference { get;  }
    }
}