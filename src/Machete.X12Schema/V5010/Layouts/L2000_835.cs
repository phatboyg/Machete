namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000_835 :
        X12Layout
    {
        Segment<LX> HeaderNumber { get; }
        
        Segment<TS3> ProviderSummaryInformation { get; }
        
        Segment<TS2> ProviderSupplemntalSummaryInformation { get; }
        
        LayoutList<L2100_835> ServiceProviderDetail { get; }
    }
}