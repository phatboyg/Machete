// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E20_DIAGNOSIS (Group) - 
    /// </summary>
    public interface EHC_E20_DIAGNOSIS :
        HL7Template
    {
        /// <summary>
        /// DG1
        /// </summary>
        Segment<DG1> DG1 { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}