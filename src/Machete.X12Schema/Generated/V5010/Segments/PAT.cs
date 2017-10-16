namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface PAT : X12Segment
    {
        Value<string> IndividualRelationshipCode { get; }

        Value<string> UnitOrBasisOfMeasurement { get; }

        Value<decimal> Weight { get; }

        Value<string> PregnancyIndicator { get; }
    }
}