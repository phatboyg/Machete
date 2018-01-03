namespace Machete.HL7.Tests.TestSchema
{
    public interface MOComponent :
        HL7Component
    {
        Value<decimal> Quantity { get; }
        Value<string> Denomination { get; }
    }
}