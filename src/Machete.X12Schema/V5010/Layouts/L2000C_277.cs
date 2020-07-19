namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000C_277 :
        X12Layout
    {
        Segment<HL> ServiceProviderLevel { get; }
        
        LayoutList<L2100C_277> ServiceProviderName { get; }
    }
}