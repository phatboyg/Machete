namespace Machete.X12Schema.V5010.Components.Maps
{
    using X12;
    using X12.Configuration;


    public class C001Map :
        X12ComponentMap<C001, X12Entity>
    {
        public C001Map()
        {
            Value(x => x.UnitOrBasisForMeasurementCode1, 0, x => x.FixedLength(2).IsRequired());
            Value(x => x.Exponent1, 1, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Multiplier1, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode2, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.Exponent2, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Multiplier2, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode3, 6, x => x.FixedLength(2).IsRequired());
            Value(x => x.Exponent3, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Multiplier3, 8, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode4, 9, x => x.FixedLength(2).IsRequired());
            Value(x => x.Exponent4, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Multiplier4, 11, x => x.MinLength(1).MaxLength(10));
            Value(x => x.UnitOrBasisForMeasurementCode5, 12, x => x.FixedLength(2).IsRequired());
            Value(x => x.Exponent5, 13, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Multiplier5, 14, x => x.MinLength(1).MaxLength(10));
        }
    }
}