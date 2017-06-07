// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RFR (Component) - Reference Range
    /// </summary>
    public interface RFR :
        HL7V26Component
    {
        /// <summary>
        /// RFR-1  Numeric Range
        /// </summary>
        /// <returns>The NR value</returns>
        Value<NR> NumericRange { get; }

        /// <summary>
        /// RFR-2  Administrative Sex
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AdministrativeSex { get; }

        /// <summary>
        /// RFR-3  Age Range
        /// </summary>
        /// <returns>The NR value</returns>
        Value<NR> AgeRange { get; }

        /// <summary>
        /// RFR-4  Gestational Age Range
        /// </summary>
        /// <returns>The NR value</returns>
        Value<NR> GestationalAgeRange { get; }

        /// <summary>
        /// RFR-5  Species
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Species { get; }

        /// <summary>
        /// RFR-6  Race/subspecies
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> RaceSubspecies { get; }

        /// <summary>
        /// RFR-7  Conditions
        /// </summary>
        /// <returns>The TX value</returns>
        Value<TX> Conditions { get; }
    }
}