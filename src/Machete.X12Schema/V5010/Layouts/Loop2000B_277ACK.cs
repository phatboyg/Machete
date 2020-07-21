namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000B_277ACK :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        Layout<Loop2100B_277ACK> Loop2100B { get; }
        
        Layout<Loop2200B_277ACK> Loop2200B { get; }
    }
}