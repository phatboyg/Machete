// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// LA2 (Component) - Location with Address Variation 2
    /// </summary>
    public interface LA2 :
        HL7V26Component
    {
        /// <summary>
        /// LA2-1  Point of Care
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PointOfCare { get; }

        /// <summary>
        /// LA2-2  Room
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Room { get; }

        /// <summary>
        /// LA2-3  Bed
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Bed { get; }

        /// <summary>
        /// LA2-4  Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> Facility { get; }

        /// <summary>
        /// LA2-5  Location Status
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> LocationStatus { get; }

        /// <summary>
        /// LA2-6  Patient Location Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PatientLocationType { get; }

        /// <summary>
        /// LA2-7  Building
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Building { get; }

        /// <summary>
        /// LA2-8  Floor
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Floor { get; }

        /// <summary>
        /// LA2-9  Street Address
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StreetAddress { get; }

        /// <summary>
        /// LA2-10  Other Designation
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OtherDesignation { get; }

        /// <summary>
        /// LA2-11  City
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> City { get; }

        /// <summary>
        /// LA2-12  State or Province
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StateOrProvince { get; }

        /// <summary>
        /// LA2-13  Zip or Postal Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ZipOrPostalCode { get; }

        /// <summary>
        /// LA2-14  Country
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Country { get; }

        /// <summary>
        /// LA2-15  Address Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AddressType { get; }

        /// <summary>
        /// LA2-16  Other Geographic Designation
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OtherGeographicDesignation { get; }
    }
}