// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M10_MF_TEST_BATTERIES (Group) - 
    /// </summary>
    public interface MFN_M10_MF_TEST_BATTERIES :
        HL7Template
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
        /// MF_TEST_BATT_DETAIL
        /// </summary>
        Group<MFN_M10_MF_TEST_BATT_DETAIL> MfTestBattDetail { get; }
    }
}