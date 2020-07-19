// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPR_PC1_ORDER (Group) - 
    /// </summary>
    public interface PPR_PC1_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Layout<PPR_PC1_ORDER_DETAIL> OrderDetail { get; }
    }
}