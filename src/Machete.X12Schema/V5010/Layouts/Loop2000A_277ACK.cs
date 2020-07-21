namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000A_277ACK :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        Layout<Loop2100A_277ACK> Loop2100A { get; }
        
        Layout<Loop2200A_277ACK> Loop2200A { get; }
    }
}