namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LFH :
        X12Segment
    {
        Value<string> HazardousMaterialShipmentInformationQualifier { get; }
        
        Value<string> HazardousMaterialShipmentInformation1 { get; }
        
        Value<string> HazardousMaterialShipmentInformation2 { get; }
        
        Value<string> HazardZoneCode { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<decimal> Quantity1 { get; }
        
        Value<decimal> Quantity2 { get; }
    }
}