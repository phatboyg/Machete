namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000D_276 :
        X12Layout
    {
        Segment<HL> Level { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Layout<L2100D_276> ServiceProviderName { get; }
        
        LayoutList<L2200D_276> ClaimStatusTrackingNumber { get; }
    }
}