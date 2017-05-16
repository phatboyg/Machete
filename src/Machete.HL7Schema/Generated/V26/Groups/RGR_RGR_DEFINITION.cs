// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RGR_RGR_DEFINITION (Group) - 
    /// </summary>
    public interface RGR_RGR_DEFINITION :
        HL7Layout
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
        Layout<RGR_RGR_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<RGR_RGR_ORDER> Order { get; }
    }
}