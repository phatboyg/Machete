// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMD_O03_ORDER_DIET (Group) - 
    /// </summary>
    public interface OMD_O03_ORDER_DIET :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING_DIET
        /// </summary>
        LayoutList<OMD_O03_TIMING_DIET> TimingDiet { get; }

        /// <summary>
        /// DIET
        /// </summary>
        Layout<OMD_O03_DIET> Diet { get; }
    }
}