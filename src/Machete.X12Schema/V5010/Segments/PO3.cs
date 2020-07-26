namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface PO3 :
        X12Segment
    {
        Value<string> ChangeReasonCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> PriceIdentifierCode { get; }
        
        Value<decimal> UnitPrice { get; }
        
        Value<string> BasisOfUnitPriceCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> UnitOrBasisForMeasurementCode { get; }
        
        Value<string> Description { get; }
    }
}