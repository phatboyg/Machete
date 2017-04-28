// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CSU_C09_STUDY_PHARM (Group) - 
    /// </summary>
    public interface CSU_C09_STUDY_PHARM :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// RX_ADMIN
        /// </summary>
        GroupList<CSU_C09_RX_ADMIN> RxAdmin { get; }
    }
}