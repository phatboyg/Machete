namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000C_277ACK :
        X12Layout
    {
        Segment<HL> BillingProviderOfServiceLevel { get; }
        
        Layout<Loop2100C_277ACK> Loop2100C { get; }
        
        Layout<Loop2200C_277ACK> Loop2200C { get; }
    }
}