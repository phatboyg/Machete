namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopV1_856 :
        X12Layout
    {
        Segment<V1> VesselIdentification { get; }
        
        SegmentList<R4> PortOrTerminal { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
    }
}