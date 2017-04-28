// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M16_MATERIAL_LOCATION (Group) - 
    /// </summary>
    public interface MFN_M16_MATERIAL_LOCATION :
        HL7Template
    {
        /// <summary>
        /// IVT
        /// </summary>
        Segment<IVT> IVT { get; }

        /// <summary>
        /// ILT
        /// </summary>
        SegmentList<ILT> ILT { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}