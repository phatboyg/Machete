namespace Machete.X12Schema.V5010
{
    using System;
    using X12;

    
    public interface PLB :
        X12Segment
    {
        Value<string> ProviderId { get; }

        Value<DateTime> FiscalPeriodDate { get; }

        Value<string> PLB03 { get; }

        Value<decimal> ProviderAdjustmentAmount1 { get; }

        Value<string> PLB05 { get; }

        Value<decimal> ProviderAdjustmentAmount2 { get; }

        Value<string> PLB07 { get; }

        Value<decimal> ProviderAdjustmentAmount3 { get; }

        Value<string> PLB09 { get; }

        Value<decimal> ProviderAdjustmentAmount4 { get; }

        Value<string> PLB11 { get; }

        Value<decimal> ProviderAdjustmentAmount5 { get; }

        Value<string> PLB13 { get; }

        Value<decimal> ProviderAdjustmentAmount6 { get; }
    }
}