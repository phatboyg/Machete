// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PTR_PCF_ORDER (Group) - 
    /// </summary>
    public interface PTR_PCF_ORDER :
        HL7Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Layout<PTR_PCF_ORDER_DETAIL> OrderDetail { get; }
    }
}