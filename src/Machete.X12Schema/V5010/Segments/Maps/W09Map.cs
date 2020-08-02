namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W09Map :
        X12SegmentMap<W09, X12Entity>
    {
        public W09Map()
        {
            Id = "W09";
            Name = "Equipment and Temperature";
            
            Value(x => x.EquipmentDescriptionCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Temperature1, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.UnitOrBasisOfMeasurementCode1, 3, x => x.FixedLength(2));
            Value(x => x.Temperature2, 4, x => x.MinLength(1).MaxLength(4));
            Value(x => x.UnitOrBasisOfMeasurementCode2, 5, x => x.FixedLength(2));
            Value(x => x.FreeformMessage, 6, x => x.MinLength(1).MaxLength(60));
            Value(x => x.VentSettingCode, 7, x => x.FixedLength(1));
            Value(x => x.PercentIntegerFormat, 8, x => x.MinLength(1).MaxLength(3));
            Value(x => x.Quantity, 9, x => x.MinLength(1).MaxLength(15));
        }
    }
}