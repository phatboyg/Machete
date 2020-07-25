namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LH4 :
        X12Segment
    {
        Value<string> EmergencyResponsePlanNumber { get; }
        
        Value<string> CommunicationNumber1 { get; }
        
        Value<string> PackingGroupCode { get; }
        
        Value<string> SubsidiaryClassification1 { get; }
        
        Value<string> SubsidiaryClassification2 { get; }
        
        Value<string> SubsidiaryClassification3 { get; }
        
        Value<string> SubsidiaryRiskIndicator { get; }
        
        Value<int> NetExplosiveQuantity { get; }
        
        Value<string> CanadianHazardousNotation { get; }
        
        Value<string> SpecialCommodityIndicatorCode { get; }
        
        Value<string> CommunicationNumber2 { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
    }
}