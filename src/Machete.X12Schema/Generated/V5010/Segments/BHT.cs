namespace Machete.X12Schema.V5010
{
    using System;

    using Machete.X12;
    public interface BHT : X12Segment
    {
        Value<string> HierarchicalStructureCode { get; }

        Value<string> TransactionSetPurposeCode { get; }

        Value<string> ReferenceIdentification { get; }

        Value<DateTime> Date { get; }

        Value<string> TransactionTypeCode { get; }
    }
}