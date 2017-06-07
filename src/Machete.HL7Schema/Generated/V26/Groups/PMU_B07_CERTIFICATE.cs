// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PMU_B07_CERTIFICATE (Group) - 
    /// </summary>
    public interface PMU_B07_CERTIFICATE :
        HL7V26Layout
    {
        /// <summary>
        /// CER
        /// </summary>
        Segment<CER> CER { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }
    }
}