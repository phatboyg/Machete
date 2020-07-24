namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class INVMap :
        X12SegmentMap<INV, X12Entity>
    {
        public INVMap()
        {
            Id = "INV";
            Name = "Investment Vehicle Selection";
            
            Value(x => x.Description1, 1, x => x.MinLength(1).MaxLength(80).IsRequired());
            Value(x => x.Percent, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.MonetaryAmount1, 3, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.StateOrProvinceCode, 5, x => x.FixedLength(2));
            Value(x => x.Description2, 6, x => x.MinLength(1).MaxLength(80));
            Value(x => x.MonetaryAmount2, 7, x => x.MinLength(1).MaxLength(18));
        }
    }
}