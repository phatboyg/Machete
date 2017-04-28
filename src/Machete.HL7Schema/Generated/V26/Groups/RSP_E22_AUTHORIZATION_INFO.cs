// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_E22_AUTHORIZATION_INFO (Group) - 
    /// </summary>
    public interface RSP_E22_AUTHORIZATION_INFO :
        HL7Template
    {
        /// <summary>
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// PSG
        /// </summary>
        Segment<PSG> PSG { get; }

        /// <summary>
        /// PSL_ITEM_INFO
        /// </summary>
        GroupList<RSP_E22_PSL_ITEM_INFO> PslItemInfo { get; }
    }
}