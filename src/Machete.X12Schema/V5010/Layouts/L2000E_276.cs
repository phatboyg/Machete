namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000E_276 :
        X12Layout
    {
        Segment<HL> Level { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Layout<L2100E_276> ServiceProviderName { get; }
        
        LayoutList<L2200E_276> ClaimStatusTrackingNumber { get; }
    }
}