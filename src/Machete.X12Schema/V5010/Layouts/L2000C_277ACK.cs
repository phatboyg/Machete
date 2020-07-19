namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2000C_277ACK :
        X12Layout
    {
        Segment<HL> BillingProviderOfServiceLevel { get; }
        
        Layout<L2100C_277ACK> BillingProviderName { get; }
        
        Layout<L2200C_277ACK> ProviderOfServiceInformationTraceIdentifier { get; }
    }
}