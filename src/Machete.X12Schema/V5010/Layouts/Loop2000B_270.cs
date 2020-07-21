namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000B_270 :
        X12Layout
    {
        Segment<HL> InformationReceiverLevel { get; }
        
        Layout<Loop2100B_270> Loop2100B { get; }
    }
}