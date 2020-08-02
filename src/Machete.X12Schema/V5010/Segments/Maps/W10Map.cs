namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W10Map :
        X12SegmentMap<W10, X12Entity>
    {
        public W10Map()
        {
            Id = "W10";
            Name = "Warehouse Additional Carrier Information";
            
            Value(x => x.UnitLoadOptionCode, 1, x => x.FixedLength(2));
            Value(x => x.QuantityOfPalletsShipped, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.PalletExchangeCode, 3, x => x.FixedLength(1));
            Value(x => x.SealNumber1, 4, x => x.MinLength(2).MaxLength(15));
            Value(x => x.SealNumber2, 5, x => x.MinLength(2).MaxLength(15));
            Value(x => x.Temperature1, 6, x => x.MinLength(1).MaxLength(4));
            Value(x => x.UnitOrBasisOfMeasurementCode1, 7, x => x.FixedLength(2));
            Value(x => x.Temperature2, 8, x => x.MinLength(1).MaxLength(4));
            Value(x => x.UnitOrBasisOfMeasurementCode2, 9, x => x.FixedLength(2));
        }
    }
}