namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class L0Map :
        X12SegmentMap<L0, X12Entity>
    {
        public L0Map()
        {
            Id = "L0";
            Name = "Line Item - Quantity and Weight";
            
            Value(x => x.LadingLineItemNumber, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.BilledOrRatedAsQuantity, 2, x => x.MinLength(1).MaxLength(11));
            Value(x => x.BilledOrRatedAsQualifier, 3, x => x.FixedLength(2));
            Value(x => x.Weight, 4, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Volume, 6, x => x.MinLength(1).MaxLength(8));
            Value(x => x.VolumeUnitQualifier, 7, x => x.FixedLength(1));
            Value(x => x.LadingQuantity, 8, x => x.MinLength(1).MaxLength(7));
            Value(x => x.PackagingFormCode1, 9, x => x.FixedLength(3));
            Value(x => x.DunnageDescription, 10, x => x.MinLength(2).MaxLength(25));
            Value(x => x.WeightUnitCode, 11, x => x.FixedLength(1));
            Value(x => x.TypeOfServiceCode, 12, x => x.FixedLength(2));
            Value(x => x.Quantity, 13, x => x.MinLength(1).MaxLength(15));
            Value(x => x.PackagingFormCode2, 14, x => x.FixedLength(3));
            Value(x => x.YesNoConditionOrResponseCode, 15, x => x.FixedLength(1));
        }
    }
}