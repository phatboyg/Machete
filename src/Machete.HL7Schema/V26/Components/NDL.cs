// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// NDL (Component) - Name with Date and Location
    /// </summary>
    public interface NDL :
        HL7V26Component
    {
        /// <summary>
        /// NDL-1  Name
        /// </summary>
        /// <returns>The CNN value</returns>
        Value<CNN> Name { get; }

        /// <summary>
        /// NDL-2  Start Date/time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> StartDateTime { get; }

        /// <summary>
        /// NDL-3  End Date/time
        /// </summary>
        /// <returns>The DateTimeOffset value</returns>
        Value<DateTimeOffset> EndDateTime { get; }

        /// <summary>
        /// NDL-4  Point of Care
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PointOfCare { get; }

        /// <summary>
        /// NDL-5  Room
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Room { get; }

        /// <summary>
        /// NDL-6  Bed
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Bed { get; }

        /// <summary>
        /// NDL-7  Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> Facility { get; }

        /// <summary>
        /// NDL-8  Location Status
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> LocationStatus { get; }

        /// <summary>
        /// NDL-9  Patient Location Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PatientLocationType { get; }

        /// <summary>
        /// NDL-10  Building
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Building { get; }

        /// <summary>
        /// NDL-11  Floor
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Floor { get; }
    }
}