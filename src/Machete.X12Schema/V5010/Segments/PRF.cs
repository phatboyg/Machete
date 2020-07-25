namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface PRF :
        X12Segment
    {
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<string> ChangeOrderSequenceNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> AssignedIdentification { get; }
        
        Value<string> ContractNumber { get; }
        
        Value<string> PurchaseOrderTypeCode { get; }
    }
}