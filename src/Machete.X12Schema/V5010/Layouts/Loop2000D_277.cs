namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000D_277 :
        X12Layout
    {
        Segment<HL> ServiceProviderLevel { get; }
        
        Layout<Loop2100D_277> Loop2100D { get; }
        
        LayoutList<Loop2200D_277> Loop2200D { get; }
    }
}