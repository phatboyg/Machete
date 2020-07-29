namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopADV_855 :
        X12Layout
    {
        Segment<ADV> AdvertisingDemographicInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<MTX> Text { get; }
    }
}