namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class CASMap : X12SegmentMap<CAS, X12Entity>
    {
        public CASMap()
        {
            Id = "CAS";
            Name = "Claims Adjustment";
            Value(x => x.GroupCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ReasonCode1, 2, x => x.MinLength(1).MaxLength(5).IsRequired());
            Value(x => x.Amount1, 3, x => x.MinLength(1).IsRequired());
            Value(x => x.Quantity1, 4, x => x.MinLength(1));
            Value(x => x.ReasonCode2, 5, x => x.MinLength(1).MaxLength(5));
            Value(x => x.Amount2, 6, x => x.MinLength(1));
            Value(x => x.Quantity2, 7, x => x.MinLength(1));
            Value(x => x.ReasonCode3, 8, x => x.MinLength(1).MaxLength(5));
            Value(x => x.Amount3, 9, x => x.MinLength(1));
            Value(x => x.Quantity3, 10, x => x.MinLength(1));
            Value(x => x.ReasonCode4, 11, x => x.MinLength(1).MaxLength(5));
            Value(x => x.Amount4, 12, x => x.MinLength(1));
            Value(x => x.Quantity4, 13, x => x.MinLength(1));
            Value(x => x.ReasonCode5, 14, x => x.MinLength(1).MaxLength(5));
            Value(x => x.Amount5, 15, x => x.MinLength(1));
            Value(x => x.Quantity5, 16, x => x.MinLength(1));
            Value(x => x.ReasonCode6, 17, x => x.MinLength(1).MaxLength(5));
            Value(x => x.Amount6, 18, x => x.MinLength(1));
            Value(x => x.Quantity6, 19, x => x.MinLength(1));
        }
    }
}