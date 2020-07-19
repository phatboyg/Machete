// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORB_O28_PATIENT (Group) - 
    /// </summary>
    public interface ORB_O28_PATIENT :
        HL7V26Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ORB_O28_ORDER> Order { get; }
    }
}