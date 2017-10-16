namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface SBR : X12Segment
    {
        Value<string> PayerResponsibilitySeqNumCode { get; }

        Value<string> IndividualRelationshipCode { get; }

        Value<string> ReferenceIdentification { get; }

        Value<string> Name { get; }

        Value<string> ClaimFilingIndicatorCode { get; }
    }
}