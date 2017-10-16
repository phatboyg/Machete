namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class SBRMap : X12SegmentMap<SBR, X12Entity>
    {
        public SBRMap()
        {
            Id = "SBR";
            Name = "Subscriber Information";
            Value(x => x.PayerResponsibilitySeqNumCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.IndividualRelationshipCode, 2, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Name, 4, x => x.MinLength(1).MaxLength(60));
            Value(x => x.ClaimFilingIndicatorCode, 9, x => x.MinLength(1).MaxLength(2));
        }
    }
}