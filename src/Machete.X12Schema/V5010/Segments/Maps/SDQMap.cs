namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class SDQMap :
        X12SegmentMap<SDQ, X12Entity>
    {
        public SDQMap()
        {
            Id = "SDQ";
            Name = "Destination Quantity";
            
            Value(x => x.UnitOrBasisForMeasurementCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.IdentificationCodeQualifier, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode1, 3, x => x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.Quantity1, 4, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.IdentificationCode2, 5, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity2, 6, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode3, 7, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity3, 8, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode4, 9, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity4, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode5, 11, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity5, 12, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode6, 13, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity6, 14, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode7, 15, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity7, 16, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode8, 17, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity8, 18, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode9, 19, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity9, 20, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IdentificationCode10, 21, x => x.MinLength(2).MaxLength(80));
            Value(x => x.Quantity10, 22, x => x.MinLength(1).MaxLength(15));
            Value(x => x.LocationIdentifier, 23, x => x.MinLength(1).MaxLength(30));
        }
    }
}