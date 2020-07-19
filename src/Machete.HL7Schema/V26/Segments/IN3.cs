// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// IN3 (Segment) - Insurance Additional Information, Certification
    /// </summary>
    public interface IN3 :
        HL7V26Segment
    {
        /// <summary>
        /// IN3-1: Set ID - IN3
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// IN3-2: Certification Number
        /// </summary>
        Value<CX> CertificationNumber { get; }

        /// <summary>
        /// IN3-3: Certified By
        /// </summary>
        ValueList<XCN> CertifiedBy { get; }

        /// <summary>
        /// IN3-4: Certification Required
        /// </summary>
        Value<string> CertificationRequired { get; }

        /// <summary>
        /// IN3-5: Penalty
        /// </summary>
        Value<MOP> Penalty { get; }

        /// <summary>
        /// IN3-6: Certification Date/Time
        /// </summary>
        Value<DateTimeOffset> CertificationDateTime { get; }

        /// <summary>
        /// IN3-7: Certification Modify Date/Time
        /// </summary>
        Value<DateTimeOffset> CertificationModifyDateTime { get; }

        /// <summary>
        /// IN3-8: Operator
        /// </summary>
        ValueList<XCN> Operator { get; }

        /// <summary>
        /// IN3-9: Certification Begin Date
        /// </summary>
        Value<DateTimeOffset> CertificationBeginDate { get; }

        /// <summary>
        /// IN3-10: Certification End Date
        /// </summary>
        Value<DateTimeOffset> CertificationEndDate { get; }

        /// <summary>
        /// IN3-11: Days
        /// </summary>
        Value<DTN> Days { get; }

        /// <summary>
        /// IN3-12: Non-Concur Code/Description
        /// </summary>
        Value<CWE> NonConcurCodeDescription { get; }

        /// <summary>
        /// IN3-13: Non-Concur Effective Date/Time
        /// </summary>
        Value<DateTimeOffset> NonConcurEffectiveDateTime { get; }

        /// <summary>
        /// IN3-14: Physician Reviewer
        /// </summary>
        ValueList<XCN> PhysicianReviewer { get; }

        /// <summary>
        /// IN3-15: Certification Contact
        /// </summary>
        Value<string> CertificationContact { get; }

        /// <summary>
        /// IN3-16: Certification Contact Phone Number
        /// </summary>
        ValueList<XTN> CertificationContactPhoneNumber { get; }

        /// <summary>
        /// IN3-17: Appeal Reason
        /// </summary>
        Value<CWE> AppealReason { get; }

        /// <summary>
        /// IN3-18: Certification Agency
        /// </summary>
        Value<CWE> CertificationAgency { get; }

        /// <summary>
        /// IN3-19: Certification Agency Phone Number
        /// </summary>
        ValueList<XTN> CertificationAgencyPhoneNumber { get; }

        /// <summary>
        /// IN3-20: Pre-Certification Requirement
        /// </summary>
        ValueList<ICD> PreCertificationRequirement { get; }

        /// <summary>
        /// IN3-21: Case Manager
        /// </summary>
        Value<string> CaseManager { get; }

        /// <summary>
        /// IN3-22: Second Opinion Date
        /// </summary>
        Value<DateTimeOffset> SecondOpinionDate { get; }

        /// <summary>
        /// IN3-23: Second Opinion Status
        /// </summary>
        Value<string> SecondOpinionStatus { get; }

        /// <summary>
        /// IN3-24: Second Opinion Documentation Received
        /// </summary>
        ValueList<string> SecondOpinionDocumentationReceived { get; }

        /// <summary>
        /// IN3-25: Second Opinion Physician
        /// </summary>
        ValueList<XCN> SecondOpinionPhysician { get; }
    }
}