namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000C_276 :
        X12Layout
    {
        Segment<HL> ServiceProviderLevel { get; }
        
        LayoutList<L2100C_276> ServiceProviderName { get; }
    }
}