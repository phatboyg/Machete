// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFR_M01_MF_QUERY (Group) - 
    /// </summary>
    public interface MFR_M01_MF_QUERY :
        HL7Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// Hxx
        /// </summary>
        Segment<HL7Segment> Hxx { get; }
    }
}