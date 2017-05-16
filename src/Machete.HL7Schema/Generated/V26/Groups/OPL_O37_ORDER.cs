// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPL_O37_ORDER (Group) - 
    /// </summary>
    public interface OPL_O37_ORDER :
        HL7Layout
    {
        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<OPL_O37_PATIENT> Patient { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        LayoutList<OPL_O37_SPECIMEN> Specimen { get; }

        /// <summary>
        /// PRIOR_RESULT
        /// </summary>
        Layout<OPL_O37_PRIOR_RESULT> PriorResult { get; }

        /// <summary>
        /// FT1
        /// </summary>
        SegmentList<FT1> FT1 { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }

        /// <summary>
        /// BLG
        /// </summary>
        Segment<BLG> BLG { get; }
    }
}