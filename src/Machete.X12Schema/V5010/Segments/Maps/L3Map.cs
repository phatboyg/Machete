namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L3Map :
        X12SegmentMap<L3, X12Entity>
    {
        public L3Map()
        {
            Id = "L3";
            Name = "Total Weight and Charges";
            
            Value(x => x.Weight, 1, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.FreightRate, 3, x => x.MinLength(1).MaxLength(9));
            Value(x => x.RateOrValueQualifier1, 4, x => x.FixedLength(2));
            Value(x => x.AmountCharged, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Advances, 6, x => x.MinLength(1).MaxLength(9));
            Value(x => x.PrepaidAmount, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.SpecialChargeOrAllowanceCode, 8, x => x.FixedLength(3));
            Value(x => x.Volume, 9, x => x.MinLength(1).MaxLength(8));
            Value(x => x.VolumeUnitQualifier, 10, x => x.FixedLength(1));
            Value(x => x.LadingQuantity, 11, x => x.MinLength(1).MaxLength(7));
            Value(x => x.WeightUnitCode, 12, x => x.FixedLength(1));
            Value(x => x.TariffNumber, 13, x => x.MinLength(1).MaxLength(7));
            Value(x => x.DeclaredValue, 14, x => x.MinLength(2).MaxLength(2));
            Value(x => x.RateOrValueQualifier2, 15, x => x.FixedLength(2));
        }
    }
}