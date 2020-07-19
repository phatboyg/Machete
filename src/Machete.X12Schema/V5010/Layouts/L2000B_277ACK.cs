namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000B_277ACK :
        X12Layout
    {
        Segment<HL> InformationSourceLevel { get; }
        
        Layout<L2100B_277ACK> InformationSourceName { get; }
        
        Layout<L2200B_277ACK> InformationReceiverApplicationTraceIdentifier { get; }
    }
}