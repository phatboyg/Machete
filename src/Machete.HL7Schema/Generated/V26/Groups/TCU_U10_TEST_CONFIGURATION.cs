// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// TCU_U10_TEST_CONFIGURATION (Group) - 
    /// </summary>
    public interface TCU_U10_TEST_CONFIGURATION :
        HL7V26Layout
    {
        /// <summary>
        /// SPM
        /// </summary>
        Segment<SPM> SPM { get; }

        /// <summary>
        /// TCC
        /// </summary>
        SegmentList<TCC> TCC { get; }
    }
}