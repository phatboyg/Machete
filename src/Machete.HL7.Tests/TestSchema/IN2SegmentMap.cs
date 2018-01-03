namespace Machete.HL7.Tests.TestSchema
{
    public class IN2SegmentMap :
        HL7SegmentMap<IN2Segment, HL7Entity>
    {
        public IN2SegmentMap()
        {
            Id = "IN2";

            Name = "Insurance Additional Information";

            Entity(x => x.InsuredSEmployeeId, 1);
            Value(x => x.InsuredSSocialSecurityNumber, 2);
            Entity(x => x.InsuredSEmployerSNameAndId, 3);
            Value(x => x.EmployerInformationData, 4);
            Value(x => x.MailClaimParty, 5);
            Value(x => x.MedicareHealthInsCardNumber, 6);
            Entity(x => x.MedicaidCaseName, 7);
            Value(x => x.MedicaidCaseNumber, 8);
            Entity(x => x.MilitarySponsorName, 9);
            Value(x => x.MilitaryIdNumber, 10);
            Entity(x => x.DependentOfMilitaryRecipient, 11);
            Value(x => x.MilitaryOrganization, 12);
            Value(x => x.MilitaryStation, 13);
            Value(x => x.MilitaryService, 14);
            Value(x => x.MilitaryRankGrade, 15);
            Value(x => x.MilitaryStatus, 16);
            Value(x => x.MilitaryRetireDate, 17, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.MilitaryNonAvailCertOnFile, 18);
            Value(x => x.BabyCoverage, 19);
            Value(x => x.CombineBabyBill, 20);
            Value(x => x.BloodDeductible, 21);
            Entity(x => x.SpecialCoverageApprovalName, 22);
            Value(x => x.SpecialCoverageApprovalTitle, 23);
            Value(x => x.NonCoveredInsuranceCode, 24);
            Entity(x => x.PayorId, 25);
            Entity(x => x.PayorSubscriberId, 26);
            Value(x => x.EligibilitySource, 27);
        }
    }
}