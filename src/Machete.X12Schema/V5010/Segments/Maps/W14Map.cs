namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W14Map :
        X12SegmentMap<W14, X12Entity>
    {
        public W14Map()
        {
            Id = "W14";
            Name = "Total Receipt Information";
            
            Value(x => x.QuantityReceived, 1, x => x.MinLength(1).MaxLength(7).IsRequired());
            Value(x => x.NumberOfUnitsShipped, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.QuantityDamagedOrOnHold, 3, x => x.MinLength(1).MaxLength(9));
            Value(x => x.LadingQuantityReceived, 4, x => x.MinLength(1).MaxLength(7));
            Value(x => x.LadingQuantity, 5, x => x.MinLength(1).MaxLength(7));
        }
    }
}