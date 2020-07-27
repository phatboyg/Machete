namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class DISMap :
        X12SegmentMap<DIS, X12Entity>
    {
        public DISMap()
        {
            Id = "DIS";
            Name = "Discount Detail";
            
            Value(x => x.DiscountTermsTypeCode, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.DiscountBaseQualifier, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.DiscountBaseValue, 3, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.DiscountControlLimitQualifier, 4, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.DiscountControlLimit1, 5, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.DiscountControlLimit2, 6, x => x.MinLength(1).MaxLength(10));
        }
    }
}