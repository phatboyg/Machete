// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CSU (Component) - Channel Sensitivity and Units
    /// </summary>
    public interface CSU :
        HL7V26Component
    {
        /// <summary>
        /// CSU-1  Channel Sensitivity
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ChannelSensitivity { get; }

        /// <summary>
        /// CSU-2  Unit of Measure Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UnitOfMeasureIdentifier { get; }

        /// <summary>
        /// CSU-3  Unit of Measure Description
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UnitOfMeasureDescription { get; }

        /// <summary>
        /// CSU-4  Unit of Measure Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UnitOfMeasureCodingSystem { get; }

        /// <summary>
        /// CSU-5  Alternate Unit of Measure Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateUnitOfMeasureIdentifier { get; }

        /// <summary>
        /// CSU-6  Alternate Unit of Measure Description
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateUnitOfMeasureDescription { get; }

        /// <summary>
        /// CSU-7  Alternate Unit of Measure Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateUnitOfMeasureCodingSystem { get; }
    }
}