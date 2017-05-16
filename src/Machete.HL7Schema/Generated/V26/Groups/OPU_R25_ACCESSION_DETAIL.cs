// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPU_R25_ACCESSION_DETAIL (Group) - 
    /// </summary>
    public interface OPU_R25_ACCESSION_DETAIL :
        HL7Layout
    {
        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<OPU_R25_PATIENT> Patient { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        LayoutList<OPU_R25_SPECIMEN> Specimen { get; }
    }
}