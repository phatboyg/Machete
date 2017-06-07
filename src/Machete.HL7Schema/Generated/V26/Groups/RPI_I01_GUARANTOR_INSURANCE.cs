// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RPI_I01_GUARANTOR_INSURANCE (Group) - 
    /// </summary>
    public interface RPI_I01_GUARANTOR_INSURANCE :
        HL7V26Layout
    {
        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<RPI_I01_INSURANCE> Insurance { get; }
    }
}