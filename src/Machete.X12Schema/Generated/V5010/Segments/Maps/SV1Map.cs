namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class SV1Map :
        X12SegmentMap<SV1, X12Entity>
    {
        public SV1Map()
        {
            Id = "SV1";
            Name = "Professional Service";
            
            Entity(x => x.ProductIdentifier, 1, x => x.IsRequired());
            Value(x => x.LineItemChargeAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
            Value(x => x.UnitForMeasurementCode, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.ServiceUnitCount, 4, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.PlaceOfServiceCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ServiceTypeCode, 6, x => x.MinLength(1).MaxLength(2));
            Entity(x => x.CompositeDiagCodePointer, 7);
            Value(x => x.EmergencyIndicator, 9, x => x.FixedLength(1));
            Value(x => x.MultipleProcedureCode, 10, x => x.MinLength(1).MaxLength(2));
            Value(x => x.EPSDTIndicator, 11, x => x.FixedLength(1));
            Value(x => x.FamilyPlanningIndicator, 12, x => x.FixedLength(1));
            Value(x => x.ReviewCode, 13, x => x.MinLength(1).MaxLength(2));
            Value(x => x.NationalAssignedReviewValue, 14, x => x.MinLength(1).MaxLength(2));
            Value(x => x.CoPayStatusCode, 15, x => x.FixedLength(1));
        }
    }
}