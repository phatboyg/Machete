// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORD_O04_RESPONSE (Group) - 
    /// </summary>
    public interface ORD_O04_RESPONSE :
        HL7V26Layout
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<ORD_O04_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER_DIET
        /// </summary>
        LayoutList<ORD_O04_ORDER_DIET> OrderDiet { get; }

        /// <summary>
        /// ORDER_TRAY
        /// </summary>
        LayoutList<ORD_O04_ORDER_TRAY> OrderTray { get; }
    }
}