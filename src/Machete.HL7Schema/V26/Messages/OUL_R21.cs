// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R21 (Message) - 
    /// </summary>
    public interface OUL_R21 :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// NTE
        /// </summary>
        Segment<NTE> NTE { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<OUL_R21_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER_OBSERVATION
        /// </summary>
        LayoutList<OUL_R21_ORDER_OBSERVATION> OrderObservation { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }
    }
}