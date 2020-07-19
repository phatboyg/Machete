namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopV1 :
        X12Layout
    {
        Segment<V1> VesselIdentification { get; }
        
        SegmentList<R4> PortOrTerminal { get; }
        
        SegmentList<DTM> MessageText { get; }
    }
}