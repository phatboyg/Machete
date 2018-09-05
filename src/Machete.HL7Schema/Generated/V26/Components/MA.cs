// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// MA (Component) - Multiplexed Array
    /// </summary>
    public interface MA :
        HL7V26Component
    {
        /// <summary>
        /// MA-1  Sample Y From Channel 1
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> SampleYFromChannel1 { get; }

        /// <summary>
        /// MA-2  Sample Y From Channel 2
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> SampleYFromChannel2 { get; }

        /// <summary>
        /// MA-3  Sample Y From Channel 3
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> SampleYFromChannel3 { get; }

        /// <summary>
        /// MA-4  Sample Y From Channel 4
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> SampleYFromChannel4 { get; }
    }
}