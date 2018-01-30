namespace Machete.X12Schema.V5010
{
    using X12;

    
    public interface PAT :
        X12Segment
    {
        Value<string> IndividualRelationshipCode { get; }
        
        Value<string> PatientLocationCode { get; }
        
        Value<string> EmploymentStatusCode { get; }
        
        Value<string> StudentStatusCode { get; }
        
        Value<string> DateTimePeriodFormatQualifier { get; }
        
        Value<DateTimePeriod> DateOfDeath { get; }

        Value<string> UnitOrBasisOfMeasurement { get; }

        Value<decimal> Weight { get; }

        Value<string> PregnancyIndicator { get; }
    }
}