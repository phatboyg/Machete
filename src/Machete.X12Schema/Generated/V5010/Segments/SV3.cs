namespace Machete.X12Schema.V5010.Segments
{
    using Components;
    using X12;


    public interface SV3 :
        X12Segment
    {
        Value<ProcedureIdentifier> MedicalProcedureIdentifier { get; }
        
        Value<decimal> LineItemChargeAmount { get; }
        
        Value<string> PlaceOfServiceCode { get; }
        
        Value<OralCavityDesignation> OralCavityDesignation { get; }
        
        Value<string> ProsthesisCrownOrInlayCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> Description { get; }
        
        Value<string> CopayStatusCode { get; }
        
        Value<string> ProviderAgreementCode { get; }
        
        Value<DiagnosisCodePointer> DiagnosisCodePointer { get; }
    }
}