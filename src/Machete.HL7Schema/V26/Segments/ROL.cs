// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// ROL (Segment) - Role
    /// </summary>
    public interface ROL :
        HL7V26Segment
    {
        /// <summary>
        /// ROL-1: Role Instance ID
        /// </summary>
        Value<EI> RoleInstanceId { get; }

        /// <summary>
        /// ROL-2: Action Code
        /// </summary>
        Value<string> ActionCode { get; }

        /// <summary>
        /// ROL-3: Role-ROL
        /// </summary>
        Value<CWE> Role { get; }

        /// <summary>
        /// ROL-4: Role Person
        /// </summary>
        ValueList<XCN> RolePerson { get; }

        /// <summary>
        /// ROL-5: Role Begin Date/Time
        /// </summary>
        Value<DateTimeOffset> RoleBeginDateTime { get; }

        /// <summary>
        /// ROL-6: Role End Date/Time
        /// </summary>
        Value<DateTimeOffset> RoleEndDateTime { get; }

        /// <summary>
        /// ROL-7: Role Duration
        /// </summary>
        Value<CWE> RoleDuration { get; }

        /// <summary>
        /// ROL-8: Role Action Reason
        /// </summary>
        Value<CWE> RoleActionReason { get; }

        /// <summary>
        /// ROL-9: Provider Type
        /// </summary>
        ValueList<CWE> ProviderType { get; }

        /// <summary>
        /// ROL-10: Organization Unit Type
        /// </summary>
        Value<CWE> OrganizationUnitType { get; }

        /// <summary>
        /// ROL-11: Office/Home Address/Birthplace
        /// </summary>
        ValueList<XAD> OfficeHomeAddressBirthplace { get; }

        /// <summary>
        /// ROL-12: Phone
        /// </summary>
        ValueList<XTN> Phone { get; }

        /// <summary>
        /// ROL-13: Person's Location
        /// </summary>
        Value<PL> PersonLocation { get; }
    }
}