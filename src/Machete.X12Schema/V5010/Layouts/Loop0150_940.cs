namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0150_940 :
        X12Layout
    {
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        Segment<AT9> TrailerOrContainerDimensionAndWeight { get; }
    }
}