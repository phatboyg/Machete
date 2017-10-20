namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class PLBMap : X12SegmentMap<PLB, X12Entity>
    {
        public PLBMap()
        {
            Id = "PLB";
            Name = "Provider Level Adjustment";
            Value(x => x.ProviderId, 1, x => x.MinLength(1).MaxLength(30).IsRequired());
            Value(x => x.FiscalPeriodDate, 2, x => x.LongDate().IsRequired());
            Value(x => x.PLB03, 3, x => x.MinLength(1).IsRequired());
            Value(x => x.ProviderAdjustmentAmount1, 4, x => x.MinLength(1).IsRequired());
            Value(x => x.PLB05, 5, x => x.MinLength(1));
            Value(x => x.ProviderAdjustmentAmount2, 6, x => x.MinLength(1));
            Value(x => x.PLB07, 7, x => x.MinLength(1));
            Value(x => x.ProviderAdjustmentAmount3, 8, x => x.MinLength(1));
            Value(x => x.PLB09, 9, x => x.MinLength(1));
            Value(x => x.ProviderAdjustmentAmount4, 10, x => x.MinLength(1));
            Value(x => x.PLB11, 11, x => x.MinLength(1));
            Value(x => x.ProviderAdjustmentAmount5, 12, x => x.MinLength(1));
            Value(x => x.PLB13, 13, x => x.MinLength(1));
            Value(x => x.ProviderAdjustmentAmount6, 14, x => x.MinLength(1));
        }
    }
}