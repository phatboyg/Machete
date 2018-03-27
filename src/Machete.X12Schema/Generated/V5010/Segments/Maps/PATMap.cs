namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class PATMap :
        X12SegmentMap<PAT, X12Entity>
    {
        public PATMap()
        {
            Id = "PAT";
            Name = "Patient Information";
            
            Value(x => x.IndividualRelationshipCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.PatientLocationCode, 2, x => x.FixedLength(1));
            Value(x => x.EmploymentStatusCode, 3, x => x.FixedLength(2));
            Value(x => x.StudentStatusCode, 4, x => x.FixedLength(1));
            Value(x => x.DateTimePeriodFormatQualifier, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.DateOfDeath, 6, x => x.Converter = X12ValueConverters.DateTimePeriod);
            Value(x => x.UnitOrBasisOfMeasurement, 7, x => x.MinLength(2).MaxLength(3));
            Value(x => x.Weight, 8, x => x.FixedLength(1));
            Value(x => x.PregnancyIndicator, 9, x => x.FixedLength(1));
        }
    }
}