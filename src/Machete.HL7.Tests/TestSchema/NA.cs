namespace Machete.HL7.Tests.TestSchema
{
    public interface NA :
        HL7Component
    {
        Value<decimal> Value1 { get; }
        Value<decimal> Value2 { get; }
        Value<decimal> Value3 { get; }
        Value<decimal> Value4 { get; }
    }
}