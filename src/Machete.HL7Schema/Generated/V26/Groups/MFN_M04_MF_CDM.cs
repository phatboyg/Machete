// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M04_MF_CDM (Group) - 
    /// </summary>
    public interface MFN_M04_MF_CDM :
        HL7Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// CDM
        /// </summary>
        Segment<CDM> CDM { get; }

        /// <summary>
        /// PRC
        /// </summary>
        SegmentList<PRC> PRC { get; }
    }
}