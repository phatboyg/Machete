namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LH1 :
        X12Segment
    {
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<int> LadingQuantity { get; }
        
        Value<int> UnitedNationsOrNorthAmericaIdentificationCode { get; }
        
        Value<int> HazardousMaterialsPage { get; }
        
        Value<int> CommodityCode { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> CompartmentIdCode { get; }
        
        Value<string> ResidueIndicatorCode { get; }
        
        Value<string> PackingGroupCode { get; }
        
        Value<string> InterimHazardousMaterialRegulatoryNumber { get; }
    }
}