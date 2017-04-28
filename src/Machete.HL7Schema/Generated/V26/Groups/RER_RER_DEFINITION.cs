// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RER_RER_DEFINITION (Group) - 
    /// </summary>
    public interface RER_RER_DEFINITION :
        HL7Template
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
        Group<RER_RER_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        GroupList<RER_RER_ORDER> Order { get; }
    }
}