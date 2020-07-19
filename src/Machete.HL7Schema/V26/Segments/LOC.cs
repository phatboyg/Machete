// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// LOC (Segment) - Location Identification
    /// </summary>
    public interface LOC :
        HL7V26Segment
    {
        /// <summary>
        /// LOC-1: Primary Key Value - LOC
        /// </summary>
        Value<PL> PrimaryKeyValue { get; }

        /// <summary>
        /// LOC-2: Location Description
        /// </summary>
        Value<string> LocationDescription { get; }

        /// <summary>
        /// LOC-3: Location Type - LOC
        /// </summary>
        ValueList<string> LocationType { get; }

        /// <summary>
        /// LOC-4: Organization Name - LOC
        /// </summary>
        ValueList<XON> OrganizationName { get; }

        /// <summary>
        /// LOC-5: Location Address
        /// </summary>
        ValueList<XAD> LocationAddress { get; }

        /// <summary>
        /// LOC-6: Location Phone
        /// </summary>
        ValueList<XTN> LocationPhone { get; }

        /// <summary>
        /// LOC-7: License Number
        /// </summary>
        ValueList<CWE> LicenseNumber { get; }

        /// <summary>
        /// LOC-8: Location Equipment
        /// </summary>
        ValueList<string> LocationEquipment { get; }

        /// <summary>
        /// LOC-9: Location Service Code
        /// </summary>
        Value<string> LocationServiceCode { get; }
    }
}