namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class L1Map :
        X12SegmentMap<L1, X12Entity>
    {
        public L1Map()
        {
            Id = "L1";
            Name = "Rate and Charges";
            
            Value(x => x.LadingLineItemNumber, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.FreightRate, 2, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateOrValueQualifier1, 3, x => x.FixedLength(2));
            Value(x => x.AmountCharged, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Advances, 5, x => x.MinLength(1).MaxLength(9));
            Value(x => x.PrepaidAmount, 6, x => x.MinLength(1).MaxLength(15));
            Value(x => x.RateCombinationPointCode, 7, x => x.MinLength(3).MaxLength(9));
            Value(x => x.SpecialChargeOrAllowanceCode, 8, x => x.FixedLength(3));
            Value(x => x.RateClassCode, 9, x => x.MinLength(1).MaxLength(3));
            Value(x => x.EntitlementCode, 10, x => x.FixedLength(1));
            Value(x => x.ChargeMethodOfPayment, 11, x => x.FixedLength(1));
            Value(x => x.SpecialChargeDescription, 12, x => x.MinLength(2).MaxLength(25));
            Value(x => x.TariffApplicationCode, 13, x => x.FixedLength(1));
            Value(x => x.DeclaredValue, 14, x => x.MinLength(2).MaxLength(12));
            Value(x => x.RateOrValueQualifier2, 15, x => x.FixedLength(2));
            Value(x => x.LadingLiabilityCode, 16, x => x.FixedLength(1));
            Value(x => x.BilledOrRatedAsQuantity, 17, x => x.MinLength(1).MaxLength(11));
            Value(x => x.BilledOrRatedAsQualifier, 18, x => x.FixedLength(2));
            Value(x => x.PercentageAsDecimal, 19, x => x.MinLength(1).MaxLength(10));
            Value(x => x.CurrencyCode, 20, x => x.FixedLength(3));
            Value(x => x.Amount, 21, x => x.MinLength(1).MaxLength(15));
            Value(x => x.LadingValue, 22, x => x.MinLength(2).MaxLength(9));
        }
    }
}