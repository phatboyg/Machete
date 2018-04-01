namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2220D_277 :
        X12Layout
    {
        Segment<SVC> Information { get; }
        
        SegmentList<STC> StatusInformation { get; }
        
        Segment<REF> ItemIdentification { get; }
        
        Segment<DTP> Date { get; }
    }
}