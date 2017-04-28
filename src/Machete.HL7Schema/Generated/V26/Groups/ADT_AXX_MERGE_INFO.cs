// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_AXX_MERGE_INFO (Group) - 
    /// </summary>
    public interface ADT_AXX_MERGE_INFO :
        HL7Template
    {
        /// <summary>
        /// MRG
        /// </summary>
        Segment<MRG> MRG { get; }

        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }
    }
}