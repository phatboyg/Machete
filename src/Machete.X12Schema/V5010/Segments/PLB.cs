namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface PLB :
        X12Segment
    {
        Value<string> ReferenceIdentification { get; }

        Value<DateTime> Date { get; }

        Value<string> AdjustmentIdentifier1 { get; }

        Value<decimal> ProviderAdjustmentAmount1 { get; }

        Value<string> AdjustmentIdentifier2 { get; }

        Value<decimal> ProviderAdjustmentAmount2 { get; }

        Value<string> AdjustmentIdentifier3 { get; }

        Value<decimal> ProviderAdjustmentAmount3 { get; }

        Value<string> AdjustmentIdentifier4 { get; }

        Value<decimal> ProviderAdjustmentAmount4 { get; }

        Value<string> AdjustmentIdentifier5 { get; }

        Value<decimal> ProviderAdjustmentAmount5 { get; }

        Value<string> AdjustmentIdentifier6 { get; }

        Value<decimal> ProviderAdjustmentAmount6 { get; }
    }
}