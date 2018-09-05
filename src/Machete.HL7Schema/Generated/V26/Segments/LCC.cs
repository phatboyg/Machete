// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// LCC (Segment) - Location Charge Code
    /// </summary>
    public interface LCC :
        HL7V26Segment
    {
        /// <summary>
        /// LCC-1: Primary Key Value - LCC
        /// </summary>
        Value<PL> PrimaryKeyValue { get; }

        /// <summary>
        /// LCC-2: Location Department
        /// </summary>
        Value<CWE> LocationDepartment { get; }

        /// <summary>
        /// LCC-3: Accommodation Type
        /// </summary>
        ValueList<CWE> AccommodationType { get; }

        /// <summary>
        /// LCC-4: Charge Code
        /// </summary>
        ValueList<CWE> ChargeCode { get; }
    }
}