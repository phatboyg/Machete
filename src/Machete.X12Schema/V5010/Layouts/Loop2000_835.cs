namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000_835 :
        X12Layout
    {
        Segment<LX> HeaderNumber { get; }
        
        Segment<TS3> ProviderSummaryInformation { get; }
        
        Segment<TS2> ProviderSupplementalSummaryInformation { get; }
        
        LayoutList<Loop2100_835> Loop2100 { get; }
    }
}