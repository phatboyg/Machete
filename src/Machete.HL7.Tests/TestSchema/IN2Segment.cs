namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface IN2Segment :
        HL7Segment
    {
        ValueList<CXComponent> InsuredSEmployeeId { get; }
        Value<string> InsuredSSocialSecurityNumber { get; }
        ValueList<XCNComponent> InsuredSEmployerSNameAndId { get; }
        Value<string> EmployerInformationData { get; }
        ValueList<string> MailClaimParty { get; }
        Value<string> MedicareHealthInsCardNumber { get; }
        ValueList<XPNComponent> MedicaidCaseName { get; }
        Value<string> MedicaidCaseNumber { get; }
        ValueList<XPNComponent> MilitarySponsorName { get; }
        Value<string> MilitaryIdNumber { get; }
        Value<CWEComponent> DependentOfMilitaryRecipient { get; }
        Value<string> MilitaryOrganization { get; }
        Value<string> MilitaryStation { get; }
        Value<string> MilitaryService { get; }
        Value<string> MilitaryRankGrade { get; }
        Value<string> MilitaryStatus { get; }
        Value<DateTimeOffset> MilitaryRetireDate { get; }
        Value<string> MilitaryNonAvailCertOnFile { get; }
        Value<string> BabyCoverage { get; }
        Value<string> CombineBabyBill { get; }
        Value<string> BloodDeductible { get; }
        ValueList<XPNComponent> SpecialCoverageApprovalName { get; }
        Value<string> SpecialCoverageApprovalTitle { get; }
        ValueList<string> NonCoveredInsuranceCode { get; }
        ValueList<CXComponent> PayorId { get; }
        ValueList<CXComponent> PayorSubscriberId { get; }
        Value<string> EligibilitySource { get; }
    }
}