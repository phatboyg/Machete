namespace Machete.X12Schema.V5010
{
    using X12;


    public interface BNX :
        X12Segment
    {
        Value<string> ShipmentWeightCode { get; }
        
        Value<string> ReferencedPatternIdentifier { get; }
        
        Value<string> BillingCode { get; }
        
        Value<string> RepetitivePatternNumber { get; }
    }
}