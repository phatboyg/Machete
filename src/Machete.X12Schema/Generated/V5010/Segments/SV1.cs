namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface SV1 :
        X12Segment
    {
        Value<ProcedureIdentifier> ProductIdentifier { get; }

        Value<decimal> LineItemChargeAmount { get; }

        Value<string> UnitForMeasurementCode { get; }

        Value<decimal> ServiceUnitCount { get; }
        
        Value<string> ServiceTypeCode { get; }

        Value<string> PlaceOfServiceCode { get; }

        Value<DiagnosisCodePointer> CompositeDiagCodePointer { get; }

        Value<string> EmergencyIndicator { get; }
        
        Value<string> MultipleProcedureCode { get; }

        Value<string> EPSDTIndicator { get; }

        Value<string> FamilyPlanningIndicator { get; }
        
        Value<string> ReviewCode { get; }
        
        Value<string> NationalAssignedReviewValue { get; }

        Value<string> CoPayStatusCode { get; }
    }
}