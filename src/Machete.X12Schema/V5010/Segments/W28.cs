namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W28 :
        X12Segment
    {
        Value<string> ConsolidationCode { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> WeightQualifier { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<int> TotalStopOffs { get; }
        
        Value<string> LocationIdentifier { get; }
        
        Value<string> LocationQualifier { get; }
        
        Value<string> BillOfLadingOrWaybillNumber { get; }
    }
}