namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000A_276 :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        Layout<Loop2100A_276> Loop2100A { get; }
    }
}