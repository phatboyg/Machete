namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopCLD_856 :
        X12Layout
    {
        Segment<CLD> LoadDetail { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        Segment<DTP> DateOrTimeOrPeriod { get; }
    }
}