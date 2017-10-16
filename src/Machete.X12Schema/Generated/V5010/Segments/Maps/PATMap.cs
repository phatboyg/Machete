namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class PATMap : X12SegmentMap<PAT, X12Entity>
    {
        public PATMap()
        {
            Id = "PAT";
            Name = "Patient Information";
            Value(x => x.IndividualRelationshipCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.UnitOrBasisOfMeasurement, 7, x => x.MinLength(2).MaxLength(3));
            Value(x => x.Weight, 8, x => x.MinLength(1));
            Value(x => x.PregnancyIndicator, 9, x => x.FixedLength(1));
        }
    }
}