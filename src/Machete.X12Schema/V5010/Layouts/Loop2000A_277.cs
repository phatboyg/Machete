namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000A_277 :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        Layout<Loop2100A_277> Loop2100A { get; }
    }
}