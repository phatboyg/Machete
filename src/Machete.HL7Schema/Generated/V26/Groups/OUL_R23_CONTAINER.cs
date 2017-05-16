// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R23_CONTAINER (Group) - 
    /// </summary>
    public interface OUL_R23_CONTAINER :
        HL7Layout
    {
        /// <summary>
        /// SAC
        /// </summary>
        Segment<SAC> SAC { get; }

        /// <summary>
        /// INV
        /// </summary>
        Segment<INV> INV { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<OUL_R23_ORDER> Order { get; }
    }
}