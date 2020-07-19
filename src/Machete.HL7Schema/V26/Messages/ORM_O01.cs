// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORM_O01 (Message) - 
    /// </summary>
    public interface ORM_O01 :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<ORM_O01_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ORM_O01_ORDER> Order { get; }
    }
}