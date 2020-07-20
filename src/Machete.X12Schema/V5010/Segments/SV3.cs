namespace Machete.X12Schema.V5010
{
    using X12;


    public interface SV3 :
        X12Segment
    {
        Value<C003> MedicalProcedureIdentifier { get; }
        
        Value<decimal> LineItemChargeAmount { get; }
        
        Value<string> PlaceOfServiceCode { get; }
        
        Value<C006> OralCavityDesignation { get; }
        
        Value<string> ProsthesisCrownOrInlayCode { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> Description { get; }
        
        Value<string> CopayStatusCode { get; }
        
        Value<string> ProviderAgreementCode { get; }
        
        Value<C004> DiagnosisCodePointer { get; }
    }
}