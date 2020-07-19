// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// LDP (Segment) - Location Department
    /// </summary>
    public interface LDP :
        HL7V26Segment
    {
        /// <summary>
        /// LDP-1: Primary Key Value - LDP
        /// </summary>
        Value<PL> PrimaryKeyValue { get; }

        /// <summary>
        /// LDP-2: Location Department
        /// </summary>
        Value<CWE> LocationDepartment { get; }

        /// <summary>
        /// LDP-3: Location Service
        /// </summary>
        ValueList<string> LocationService { get; }

        /// <summary>
        /// LDP-4: Specialty Type
        /// </summary>
        ValueList<CWE> SpecialtyType { get; }

        /// <summary>
        /// LDP-5: Valid Patient Classes
        /// </summary>
        ValueList<string> ValidPatientClasses { get; }

        /// <summary>
        /// LDP-6: Active/Inactive Flag
        /// </summary>
        Value<string> ActiveInactiveFlag { get; }

        /// <summary>
        /// LDP-7: Activation Date - LDP
        /// </summary>
        Value<DateTimeOffset> ActivationDate { get; }

        /// <summary>
        /// LDP-8: Inactivation Date - LDP
        /// </summary>
        Value<DateTimeOffset> InactivationDate { get; }

        /// <summary>
        /// LDP-9: Inactivated Reason
        /// </summary>
        Value<string> InactivatedReason { get; }

        /// <summary>
        /// LDP-10: Visiting Hours
        /// </summary>
        ValueList<VH> VisitingHours { get; }

        /// <summary>
        /// LDP-11: Contact Phone
        /// </summary>
        Value<XTN> ContactPhone { get; }

        /// <summary>
        /// LDP-12: Location Cost Center
        /// </summary>
        Value<CWE> LocationCostCenter { get; }
    }
}