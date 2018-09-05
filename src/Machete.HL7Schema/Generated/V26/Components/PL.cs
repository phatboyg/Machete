// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// PL (Component) - Person Location
    /// </summary>
    public interface PL :
        HL7V26Component
    {
        /// <summary>
        /// PL-1  Point of Care
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PointOfCare { get; }

        /// <summary>
        /// PL-2  Room
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Room { get; }

        /// <summary>
        /// PL-3  Bed
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Bed { get; }

        /// <summary>
        /// PL-4  Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> Facility { get; }

        /// <summary>
        /// PL-5  Location Status
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> LocationStatus { get; }

        /// <summary>
        /// PL-6  Person Location Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PersonLocationType { get; }

        /// <summary>
        /// PL-7  Building
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Building { get; }

        /// <summary>
        /// PL-8  Floor
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Floor { get; }

        /// <summary>
        /// PL-9  Location Description
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> LocationDescription { get; }

        /// <summary>
        /// PL-10  Comprehensive Location Identifier
        /// </summary>
        /// <returns>The EI value</returns>
        Value<EI> ComprehensiveLocationIdentifier { get; }

        /// <summary>
        /// PL-11  Assigning Authority for Location
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningAuthorityForLocation { get; }
    }
}