namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L10 :
        X12Segment
    {
        Value<decimal> Weight { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<string> WeightUnitCode { get; }
    }
}