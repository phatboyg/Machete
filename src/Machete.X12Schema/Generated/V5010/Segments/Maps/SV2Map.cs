namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class SV2Map :
        X12SegmentMap<SV2, X12Entity>
    {
        public SV2Map()
        {
            Id = "SV2";
            Name = "Institutional Service";
            
            Value(x => x.ServiceLineRevenueCode, 1, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.ServiceLineProcedureCode, 2, x => x.FixedLength(1));
            Value(x => x.LineItemChargeAmount, 3, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.UnitForMeasurementCode, 4, x => x.FixedLength(2).IsRequired());
            Value(x => x.ServiceUnitCount, 5, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.ServiceLineRate, 6, x => x.MinLength(1).MaxLength(10));
            Value(x => x.NonCoveredChargeAmount, 7, x => x.MinLength(1).MaxLength(18));
        }
    }
}