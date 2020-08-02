namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W08Map :
        X12SegmentMap<W08, X12Entity>
    {
        public W08Map()
        {
            Id = "W08";
            Name = "Receipt Carrier Information";
            
            Value(x => x.TransportationMethodOrTypeCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.StandardCarrierAlphaCode, 2, x => x.MinLength(2).MaxLength(4));
            Value(x => x.Routing, 3, x => x.MinLength(1).MaxLength(35));
            Value(x => x.EquipmentInitial, 4, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.SealNumber1, 6, x => x.MinLength(2).MaxLength(15));
            Value(x => x.SealNumber2, 7, x => x.MinLength(2).MaxLength(15));
            Value(x => x.SealStatusCode, 8, x => x.FixedLength(2));
            Value(x => x.UnitLoadOptionCode, 9, x => x.FixedLength(2));
        }
    }
}