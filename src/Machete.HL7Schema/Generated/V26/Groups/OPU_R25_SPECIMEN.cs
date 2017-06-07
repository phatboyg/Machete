// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPU_R25_SPECIMEN (Group) - 
    /// </summary>
    public interface OPU_R25_SPECIMEN :
        HL7V26Layout
    {
        /// <summary>
        /// SPM
        /// </summary>
        Segment<SPM> SPM { get; }

        /// <summary>
        /// SPECIMEN_OBSERVATION
        /// </summary>
        LayoutList<OPU_R25_SPECIMEN_OBSERVATION> SpecimenObservation { get; }

        /// <summary>
        /// CONTAINER
        /// </summary>
        LayoutList<OPU_R25_CONTAINER> Container { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<OPU_R25_ORDER> Order { get; }
    }
}