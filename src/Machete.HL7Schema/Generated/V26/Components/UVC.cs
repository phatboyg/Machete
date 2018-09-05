// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// UVC (Component) - UB Value Code and Amount
    /// </summary>
    public interface UVC :
        HL7V26Component
    {
        /// <summary>
        /// UVC-1  Value Code
        /// </summary>
        /// <returns>The CNE value</returns>
        Value<CNE> ValueCode { get; }

        /// <summary>
        /// UVC-2  Value Amount
        /// </summary>
        /// <returns>The MO value</returns>
        Value<MO> ValueAmount { get; }
    }
}