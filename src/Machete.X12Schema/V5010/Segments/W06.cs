namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface W06 :
        X12Segment
    {
        Value<string> ReportingCode { get; }
        
        Value<string> DepositorOrderNumber { get; }
        
        Value<DateTime> Date { get; }

        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<string> AgentShipmentIdNumber { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> MasterReferenceNumber { get; }
        
        Value<int> LinkSequenceNumber { get; }
        
        Value<string> SpecialHandlingCode { get; }
        
        Value<string> ShippingDateChangeReasonCode { get; }
        
        Value<string> TransactionTypeCode { get; }
        
        Value<string> ActionCode { get; }
    }
}