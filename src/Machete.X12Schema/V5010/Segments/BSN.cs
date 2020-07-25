namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface BSN :
        X12Segment
    {
        Value<string> TransactionSetPurposeCode { get; }

        Value<string> ShipmentIdentification { get; }

        Value<DateTime> Date { get; }

        Value<TimeSpan> Time { get; }
        
        Value<string> HierarchicalStructureCode { get; }

        Value<string> TransactionTypeCode { get; }
        
        Value<string> StatusReasonCode { get; }
    }
}