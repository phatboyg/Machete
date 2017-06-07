// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPT_PCL_ORDER (Group) - 
    /// </summary>
    public interface PPT_PCL_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Layout<PPT_PCL_ORDER_DETAIL> OrderDetail { get; }
    }
}