namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class RPAMap :
        X12SegmentMap<RPA, X12Entity>
    {
        public RPAMap()
        {
            Id = "RPA";
            Name = "Rate Amounts or Percents";
            
            Value(x => x.RateOrValueTypeCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.MonetaryAmount, 2, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Rate, 3, x => x.MinLength(1).MaxLength(9));
            Entity(x => x.CompositeUnitOfMeasure, 4);
            Value(x => x.PercentageAsDecimal, 5, x => x.MinLength(1).MaxLength(10));
        }
    }
}