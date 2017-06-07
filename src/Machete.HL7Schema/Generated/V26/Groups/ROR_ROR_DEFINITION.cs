// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ROR_ROR_DEFINITION (Group) - 
    /// </summary>
    public interface ROR_ROR_DEFINITION :
        HL7V26Layout
    {
        /// <summary>
        /// QRD
        /// </summary>
        Segment<QRD> QRD { get; }

        /// <summary>
        /// QRF
        /// </summary>
        Segment<QRF> QRF { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<ROR_ROR_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ROR_ROR_ORDER> Order { get; }
    }
}