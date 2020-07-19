// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M08_MF_TEST_NUMERIC (Group) - 
    /// </summary>
    public interface MFN_M08_MF_TEST_NUMERIC :
        HL7V26Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// OM1
        /// </summary>
        Segment<OM1> OM1 { get; }

        /// <summary>
        /// OM2
        /// </summary>
        Segment<OM2> OM2 { get; }

        /// <summary>
        /// OM3
        /// </summary>
        Segment<OM3> OM3 { get; }

        /// <summary>
        /// OM4
        /// </summary>
        Segment<OM4> OM4 { get; }
    }
}