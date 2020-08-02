namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W18Map :
        X12SegmentMap<W18, X12Entity>
    {
        public W18Map()
        {
            Id = "W18";
            Name = "Probe Temperatures";
            
            Value(x => x.TemperatureProbeLocationCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Temperature, 2, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.UnitOrBasisOfMeasurementCode, 3, x => x.FixedLength(2));
        }
    }
}