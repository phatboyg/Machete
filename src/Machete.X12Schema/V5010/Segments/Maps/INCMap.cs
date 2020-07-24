namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class INCMap :
        X12SegmentMap<INC, X12Entity>
    {
        public INCMap()
        {
            Id = "INC";
            Name = "Installment Information";
            
            Value(x => x.TermsTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Entity(x => x.CompositeUnitOfMeasure, 2, x => x.IsRequired());
            Value(x => x.Quantity1, 3, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.Quantity2, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.MonetaryAmount, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AmountQualifierCode, 6, x => x.MinLength(1).MaxLength(3));
        }
    }
}