namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class SVCMap : X12SegmentMap<SVC, X12Entity>
    {
        public SVCMap()
        {
            Id = "SVC";
            Name = "Service Information";
            Value(x => x.SVC01, 1, x => x.MinLength(1).IsRequired());
            Value(x => x.LineItemCharge, 2, x => x.MinLength(1).IsRequired());
            Value(x => x.LineItemPayment, 3, x => x.MinLength(1).IsRequired());
            Value(x => x.RevenueCode, 4, x => x.MinLength(1).MaxLength(48));
            Value(x => x.UnitsOfServicePaidCount, 5, x => x.MinLength(1));
            Value(x => x.SVC06, 6, x => x.MinLength(1));
            Value(x => x.OriginalUnitsOfService, 7, x => x.MinLength(1));
        }
    }
}