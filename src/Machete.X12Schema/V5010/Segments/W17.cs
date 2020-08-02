namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface W17 :
        X12Segment
    {
        Value<string> ReportingCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> WarehouseReceiptNumber { get; }
        
        Value<string> DepositorOrderNumber { get; }
        
        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<string> TimeQualifier { get; }
        
        Value<TimeSpan> Time { get; }
        
        Value<string> MasterReferenceNumber { get; }
        
        Value<int> LinkSequenceNumber { get; }
    }
}