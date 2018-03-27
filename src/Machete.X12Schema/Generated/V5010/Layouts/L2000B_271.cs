namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000B_271 :
        X12Layout
    {
        Segment<HL> InformationReceiverLevel { get; }
        
        Layout<L2100B_271> InformationReceiver { get; }
    }
}