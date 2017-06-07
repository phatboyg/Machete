// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORL_O36_SPECIMEN (Group) - 
    /// </summary>
    public interface ORL_O36_SPECIMEN :
        HL7V26Layout
    {
        /// <summary>
        /// SPM
        /// </summary>
        Segment<SPM> SPM { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// SPECIMEN_CONTAINER
        /// </summary>
        LayoutList<ORL_O36_SPECIMEN_CONTAINER> SpecimenContainer { get; }
    }
}