namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CASMap :
        X12SegmentMap<CAS, X12Entity>
    {
        public CASMap()
        {
            Id = "CAS";
            Name = "Claims Adjustment";
            
            Value(x => x.ClaimAdjustmentGroupCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.AdjustmentReasonCode1, 2, x => x.MinLength(1).MaxLength(5).IsRequired());
            Value(x => x.AdjustmentAmount1, 3, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.Quantity1, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AdjustmentReasonCode2, 5, x => x.MinLength(1).MaxLength(5));
            Value(x => x.AdjustmentAmount2, 6, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity2, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AdjustmentReasonCode3, 8, x => x.MinLength(1).MaxLength(5));
            Value(x => x.AdjustmentAmount3, 9, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity3, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AdjustmentReasonCode4, 11, x => x.MinLength(1).MaxLength(5));
            Value(x => x.AdjustmentAmount4, 12, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity4, 13, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AdjustmentReasonCode5, 14, x => x.MinLength(1).MaxLength(5));
            Value(x => x.AdjustmentAmount5, 15, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity5, 16, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AdjustmentReasonCode6, 17, x => x.MinLength(1).MaxLength(5));
            Value(x => x.AdjustmentAmount6, 18, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity6, 19, x => x.MinLength(1).MaxLength(15));
        }
    }
}