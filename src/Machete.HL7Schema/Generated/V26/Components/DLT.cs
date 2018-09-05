// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// DLT (Component) - Delta
    /// </summary>
    public interface DLT :
        HL7V26Component
    {
        /// <summary>
        /// DLT-1  Normal Range
        /// </summary>
        /// <returns>The NR value</returns>
        Value<NR> NormalRange { get; }

        /// <summary>
        /// DLT-2  Numeric Threshold
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> NumericThreshold { get; }

        /// <summary>
        /// DLT-3  Change Computation
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ChangeComputation { get; }

        /// <summary>
        /// DLT-4  Days Retained
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> DayRetained { get; }
    }
}