namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface GT1Segment :
        HL7Segment
    {
        Value<int> SetId { get; }
        ValueList<CXComponent> GuarantorNumber { get; }
        ValueList<XPNComponent> GuarantorName { get; }
        ValueList<XPNComponent> GuarantorSpouseName { get; }
        ValueList<XADComponent> GuarantorAddress { get; }
        ValueList<XTNComponent> GuarantorPhNumHome { get; }
        ValueList<XTNComponent> GuarantorPhNumBusiness { get; }
        Value<DateTimeOffset> GuarantorDateTimeOfBirth { get; }
        Value<string> GuarantorAdministrativeSex { get; }
        Value<string> GuarantorType { get; }
        Value<CWEComponent> GuarantorRelationship { get; }
        Value<string> GuarantorSSN { get; }
        Value<DateTimeOffset> GuarantorDateBegin { get; }
        Value<DateTimeOffset> GuarantorDateEnd { get; }
        Value<decimal> GuarantorPriority { get; }
        ValueList<XPNComponent> GuarantorEmployerName { get; }
        ValueList<XADComponent> GuarantorEmployerAddress { get; }
        ValueList<XTNComponent> GuarantorEmployerPhoneNumber { get; }
        ValueList<CXComponent> GuarantorEmployeeIdNumber { get; }
        Value<string> GuarantorEmploymentStatus { get; }
        ValueList<XONComponent> GuarantorOrganizationName { get; }
        Value<string> GuarantorBillingHoldFlag { get; }
        Value<CWEComponent> GuarantorCreditRatingCode { get; }
        Value<DateTimeOffset> GuarantorDeathDateAndTime { get; }
        Value<string> GuarantorDeathFlag { get; }
        Value<CWEComponent> GuarantorChargeAdjustmentCode { get; }
        Value<CPComponent> GuarantorHouseholdAnnualIncome { get; }
        Value<decimal> GuarantorHouseholdSize { get; }
        ValueList<CXComponent> GuarantorEmployerIdNumber { get; }
        Value<CWEComponent> GuarantorMaritalStatusCode { get; }
        Value<DateTimeOffset> GuarantorHireEffectiveDate { get; }
        Value<DateTimeOffset> EmploymentStopDate { get; }
        Value<string> LivingDependency { get; }
        ValueList<string> AmbulatoryStatus { get; }
        ValueList<CWEComponent> Citizenship { get; }
        Value<CWEComponent> PrimaryLanguage { get; }
        Value<string> LivingArrangement { get; }
        Value<CWEComponent> PublicityCode { get; }
        Value<string> ProtectionIndicator { get; }
        Value<string> StudentIndicator { get; }
        Value<CWEComponent> Religion { get; }
        ValueList<XPNComponent> MotherSMaidenName { get; }
        Value<CWEComponent> Nationality { get; }
        ValueList<CWEComponent> EthnicGroup { get; }
        ValueList<XPNComponent> ContactPersonSName { get; }
        ValueList<XTNComponent> ContactPersonSTelephoneNumber { get; }
        Value<CWEComponent> ContactReason { get; }
        Value<string> ContactRelationship { get; }
        Value<string> JobTitle { get; }
        Value<JCCComponent> JobCodeClass { get; }
        ValueList<XONComponent> GuarantorEmployerSOrganizationName { get; }
        Value<string> Handicap { get; }
        Value<string> JobStatus { get; }
        Value<FCComponent> GuarantorFinancialClass { get; }
        ValueList<CWEComponent> GuarantorRace { get; }
        Value<string> GuarantorBirthPlace { get; }
        Value<string> VIPIndicator { get; }
    }
}