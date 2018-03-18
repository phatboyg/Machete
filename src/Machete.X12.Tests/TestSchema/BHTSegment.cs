namespace Machete.X12.Tests.TestSchema
{
    using System;


    public interface BHTSegment :
        X12Segment
    {
        Value<string> HierarchicalStructureCode { get; }

        Value<string> TransactionSetPurposeCode { get; }

        Value<string> ReferenceIdentification { get; }

        Value<DateTime> Date { get; }

        Value<DateTime> Time { get; }

        Value<string> TransactionTypeCode { get; }
    }
}