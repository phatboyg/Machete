namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_277 :
        X12Layout
    {
        Segment<HL> ServiceProviderLevel { get; }
        
        LayoutList<Loop2100C_277> Loop2100C { get; }
    }
}