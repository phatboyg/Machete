namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000D_276 :
        X12Layout
    {
        Segment<HL> SubscriberLevel { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Layout<Loop2100D_276> Loop2100D { get; }
        
        LayoutList<Loop2200D_276> Loop2200D { get; }
    }
}