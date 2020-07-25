namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ETD :
        X12Segment
    {
        Value<string> ExcessTransportationReasonCode { get; }
        
        Value<string> ExcessTransportationResponsibilityCode { get; }
        
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> ReturnableContainerFreightPaymentResponsibilityCode { get; }
    }
}