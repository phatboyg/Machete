namespace Machete.HL7.Tests.TestSchema
{
    public interface CPComponent :
        HL7Component
    {
        Value<MOComponent> Price { get; }
        Value<string> PriceType { get; }
        Value<decimal> FromValue { get; }
        Value<decimal> ToValue { get; }
        Value<CWEComponent> RangeUnits { get; }
        Value<string> RangeType { get; }
    }
}