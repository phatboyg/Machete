// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PD1 (Segment) - Patient Additional Demographic
    /// </summary>
    public interface PD1 :
        HL7V26Segment
    {
        /// <summary>
        /// PD1-1: Living Dependency
        /// </summary>
        ValueList<string> LivingDependency { get; }

        /// <summary>
        /// PD1-2: Living Arrangement
        /// </summary>
        Value<string> LivingArrangement { get; }

        /// <summary>
        /// PD1-3: Patient Primary Facility
        /// </summary>
        ValueList<XON> PatientPrimaryFacility { get; }

        /// <summary>
        /// PD1-4: Patient Primary Care Provider Name & ID No.
        /// </summary>
        ValueList<XCN> PatientPrimaryCareProviderNameIdNo { get; }

        /// <summary>
        /// PD1-5: Student Indicator
        /// </summary>
        Value<string> StudentIndicator { get; }

        /// <summary>
        /// PD1-6: Handicap
        /// </summary>
        Value<string> Handicap { get; }

        /// <summary>
        /// PD1-7: Living Will Code
        /// </summary>
        Value<string> LivingWillCode { get; }

        /// <summary>
        /// PD1-8: Organ Donor Code
        /// </summary>
        Value<string> OrganDonorCode { get; }

        /// <summary>
        /// PD1-9: Separate Bill
        /// </summary>
        Value<string> SeparateBill { get; }

        /// <summary>
        /// PD1-10: Duplicate Patient
        /// </summary>
        ValueList<CX> DuplicatePatient { get; }

        /// <summary>
        /// PD1-11: Publicity Code
        /// </summary>
        Value<CWE> PublicityCode { get; }

        /// <summary>
        /// PD1-12: Protection Indicator
        /// </summary>
        Value<string> ProtectionIndicator { get; }

        /// <summary>
        /// PD1-13: Protection Indicator Effective Date
        /// </summary>
        Value<DateTimeOffset> ProtectionIndicatorEffectiveDate { get; }

        /// <summary>
        /// PD1-14: Place of Worship
        /// </summary>
        ValueList<XON> PlaceOfWorship { get; }

        /// <summary>
        /// PD1-15: Advance Directive Code
        /// </summary>
        ValueList<CWE> AdvanceDirectiveCode { get; }

        /// <summary>
        /// PD1-16: Immunization Registry Status
        /// </summary>
        Value<string> ImmunizationRegistryStatus { get; }

        /// <summary>
        /// PD1-17: Immunization Registry Status Effective Date
        /// </summary>
        Value<DateTimeOffset> ImmunizationRegistryStatusEffectiveDate { get; }

        /// <summary>
        /// PD1-18: Publicity Code Effective Date
        /// </summary>
        Value<DateTimeOffset> PublicityCodeEffectiveDate { get; }

        /// <summary>
        /// PD1-19: Military Branch
        /// </summary>
        Value<string> MilitaryBranch { get; }

        /// <summary>
        /// PD1-20: Military Rank/Grade
        /// </summary>
        Value<string> MilitaryRankGrade { get; }

        /// <summary>
        /// PD1-21: Military Status
        /// </summary>
        Value<string> MilitaryStatus { get; }

        /// <summary>
        /// PD1-22: Advance Directive Last Verified Date
        /// </summary>
        Value<DateTimeOffset> AdvanceDirectiveLastVerifiedDate { get; }
    }
}