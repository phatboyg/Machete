namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BSS :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }
        
        Value<string> ReferenceIdentification1 { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<string> ScheduleTypeQualifier1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<DateTime> Date3 { get; }
        
        Value<string> ReleaseNumber { get; }
        
        Value<string> ReferenceIdentification2 { get; }
        
        Value<string> ContractNumber { get; }
        
        Value<string> PurchaseOrderNumber { get; }
        
        Value<string> ScheduleTypeQualifier2 { get; }
    }
}