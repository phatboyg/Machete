namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LH2Map :
        X12SegmentMap<LH2, X12Entity>
    {
        public LH2Map()
        {
            Id = "LH2";
            Name = "Hazardous Classification Information";
            
            Value(x => x.HazardousClassification, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.HazardousClassQualifier, 2, x => x.FixedLength(1));
            Value(x => x.HazardousPlacardNotation, 3, x => x.MinLength(1).MaxLength(7));
            Value(x => x.HazardousEndorsement, 4, x => x.FixedLength(6));
            Value(x => x.ReportableQuantityCode, 5, x => x.FixedLength(2));
            Value(x => x.UnitOrBasisForMeasurementCode1, 6, x => x.FixedLength(2));
            Value(x => x.Temperature1, 7, x => x.MinLength(1).MaxLength(4));
            Value(x => x.UnitOrBasisForMeasurementCode2, 8, x => x.FixedLength(2));
            Value(x => x.Temperature2, 9, x => x.MinLength(1).MaxLength(4));
            Value(x => x.UnitOrBasisForMeasurementCode3, 10, x => x.FixedLength(2));
            Value(x => x.Temperature3, 11, x => x.MinLength(1).MaxLength(4));
        }
    }
}