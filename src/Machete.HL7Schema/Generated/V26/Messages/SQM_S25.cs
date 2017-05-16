// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SQM_S25 (Message) - 
    /// </summary>
    public interface SQM_S25 :
        HL7Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// QRD
        /// </summary>
        Segment<QRD> QRD { get; }

        /// <summary>
        /// QRF
        /// </summary>
        Segment<QRF> QRF { get; }

        /// <summary>
        /// REQUEST
        /// </summary>
        Layout<SQM_S25_REQUEST> Request { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }
    }
}