// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// LA1 (Component) - Location with Address Variation 1
    /// </summary>
    public interface LA1 :
        HL7V26Component
    {
        /// <summary>
        /// LA1-1  Point of Care
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PointOfCare { get; }

        /// <summary>
        /// LA1-2  Room
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Room { get; }

        /// <summary>
        /// LA1-3  Bed
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Bed { get; }

        /// <summary>
        /// LA1-4  Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> Facility { get; }

        /// <summary>
        /// LA1-5  Location Status
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> LocationStatus { get; }

        /// <summary>
        /// LA1-6  Patient Location Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PatientLocationType { get; }

        /// <summary>
        /// LA1-7  Building
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Building { get; }

        /// <summary>
        /// LA1-8  Floor
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Floor { get; }

        /// <summary>
        /// LA1-9  Address
        /// </summary>
        /// <returns>The AD value</returns>
        Value<AD> Address { get; }
    }
}