namespace Machete.X12Schema.V5010
{
    using X12;


    public interface BX :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> TransportationMethodCode { get; }
        
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> WeightUnitCode { get; }
        
        Value<string> ShipmentQualifier { get; }
        
        Value<string> SectionSevenCode { get; }
        
        Value<string> CapacityLoadCode { get; }
        
        Value<string> StatusReportRequestCode { get; }
        
        Value<string> CustomsDocumentationHandlingCode { get; }
        
        Value<string> ConfidentialBillingRequestCode { get; }
        
        Value<string> GoodsAndServicesTaxReasonCode { get; }
        
        Value<string> ApplicationType { get; }
    }
}