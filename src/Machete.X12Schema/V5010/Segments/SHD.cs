namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface SHD :
        X12Segment
    {
        Value<decimal> NumberOfUnitsShipped { get; }
        
        Value<decimal> QuantityReceived { get; }
        
        Value<string> UnitOrBasisForMeasurementCode1 { get; }
        
        Value<decimal> Weight { get; }
        
        Value<string> UnitOrBasisForMeasurementCode2 { get; }
        
        Value<decimal> Volume { get; }
        
        Value<string> UnitOrBasisForMeasurementCode3 { get; }
        
        Value<decimal> OrderSizingFactor { get; }
        
        Value<string> PriceBracketIdentifier { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> ShipmentOrOrderStatusCode { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
    }
}