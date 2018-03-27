namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class SBRMap :
        X12SegmentMap<SBR, X12Entity>
    {
        public SBRMap()
        {
            Id = "SBR";
            Name = "Subscriber Information";
            
            Value(x => x.PayerResponsibilitySeqNumCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.IndividualRelationshipCode, 2, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Name, 4, x => x.MinLength(1).MaxLength(60));
            Value(x => x.InsuranceTypeCode, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CoordinationOfBenefitsCode, 6, x => x.MinLength(1).MaxLength(1));
            Value(x => x.ResponseCode, 7, x => x.FixedLength(1));
            Value(x => x.EmploymentStatusCode, 8, x => x.FixedLength(2));
            Value(x => x.ClaimFilingIndicatorCode, 9, x => x.MinLength(1).MaxLength(2));
        }
    }
}