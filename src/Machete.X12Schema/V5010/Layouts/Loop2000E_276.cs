namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000E_276 :
        X12Layout
    {
        Segment<HL> Level { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Layout<Loop2100E_276> Loop2100E { get; }
        
        LayoutList<Loop2200E_276> Loop2200E { get; }
    }
}