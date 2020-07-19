namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class BALMap :
        X12SegmentMap<BAL, X12Entity>
    {
        public BALMap()
        {
            Id = "BAL";
            Name = "Balance Detail";
            
            Value(x => x.BalanceTypeCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.AmountQualifierCode, 2, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.MonetaryAmount, 3, x => x.MinLength(1).MaxLength(18).IsRequired());
        }
    }
}