// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// MOC (Component) - Money and Code
    /// </summary>
    public interface MOC :
        HL7V26Component
    {
        /// <summary>
        /// MOC-1  Monetary Amount
        /// </summary>
        /// <returns>The MO value</returns>
        Value<MO> MonetaryAmount { get; }

        /// <summary>
        /// MOC-2  Charge Code
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> ChargeCode { get; }
    }
}