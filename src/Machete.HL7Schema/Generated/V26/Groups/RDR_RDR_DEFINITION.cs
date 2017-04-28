// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RDR_RDR_DEFINITION (Group) - 
    /// </summary>
    public interface RDR_RDR_DEFINITION :
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
        Group<RDR_RDR_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        GroupList<RDR_RDR_ORDER> Order { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }
    }
}