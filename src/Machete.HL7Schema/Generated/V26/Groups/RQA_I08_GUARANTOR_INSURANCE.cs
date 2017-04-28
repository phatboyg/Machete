// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RQA_I08_GUARANTOR_INSURANCE (Group) - 
    /// </summary>
    public interface RQA_I08_GUARANTOR_INSURANCE :
        HL7Template
    {
        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        GroupList<RQA_I08_INSURANCE> Insurance { get; }
    }
}