namespace Machete.X12Schema.V5010
{
    using Components;
    using X12;
    
    
    public interface SV5 :
        X12Segment
    {
        Value<ProcedureIdentifier> ProcedureIdentifier { get; }
        
        Value<string> UnitForMeasurementCode { get; }

        Value<decimal> LengthOfMedicalNecessity { get; }

        Value<decimal> DMERentalPrice { get; }

        Value<decimal> DMEPurchasePrice { get; }

        Value<string> RentalUnitPriceIndicator { get; }
    }
}