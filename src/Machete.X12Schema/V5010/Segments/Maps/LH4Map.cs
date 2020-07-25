namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LH4Map :
        X12SegmentMap<LH4, X12Entity>
    {
        public LH4Map()
        {
            Id = "LH4";
            Name = "Canadian Dangerous Requirements";
            
            Value(x => x.EmergencyResponsePlanNumber, 1, x => x.MinLength(1).MaxLength(12));
            Value(x => x.CommunicationNumber1, 2, x => x.MinLength(1).MaxLength(80));
            Value(x => x.PackingGroupCode, 3, x => x.MinLength(1).MaxLength(3));
            Value(x => x.SubsidiaryClassification1, 4, x => x.MinLength(1).MaxLength(3));
            Value(x => x.SubsidiaryClassification2, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.SubsidiaryClassification3, 6, x => x.MinLength(1).MaxLength(3));
            Value(x => x.SubsidiaryRiskIndicator, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.NetExplosiveQuantity, 8, x => x.MinLength(1).MaxLength(6));
            Value(x => x.CanadianHazardousNotation, 9, x => x.MinLength(1).MaxLength(25));
            Value(x => x.SpecialCommodityIndicatorCode, 10, x => x.FixedLength(1));
            Value(x => x.CommunicationNumber2, 11, x => x.MinLength(1).MaxLength(80));
            Value(x => x.UnitOrBasisForMeasurementCode, 12, x => x.FixedLength(2));
        }
    }
}