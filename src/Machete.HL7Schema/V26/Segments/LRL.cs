// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// LRL (Segment) - Location Relationship
    /// </summary>
    public interface LRL :
        HL7V26Segment
    {
        /// <summary>
        /// LRL-1: Primary Key Value - LRL
        /// </summary>
        Value<PL> PrimaryKeyValue { get; }

        /// <summary>
        /// LRL-2: Segment Action Code
        /// </summary>
        Value<string> SegmentActionCode { get; }

        /// <summary>
        /// LRL-3: Segment Unique Key
        /// </summary>
        Value<EI> SegmentUniqueKey { get; }

        /// <summary>
        /// LRL-4: Location Relationship ID
        /// </summary>
        Value<CWE> LocationRelationshipId { get; }

        /// <summary>
        /// LRL-5: Organizational Location Relationship Value
        /// </summary>
        ValueList<XON> OrganizationalLocationRelationshipValue { get; }

        /// <summary>
        /// LRL-6: Patient Location Relationship Value
        /// </summary>
        Value<PL> PatientLocationRelationshipValue { get; }
    }
}