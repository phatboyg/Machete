namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_276 :
        X12Layout
    {
        Segment<HL> ServiceProviderLevel { get; }
        
        LayoutList<Loop2100C_276> Loop2100C { get; }
    }
}