// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORL_O36_SPECIMEN_CONTAINER (Group) - 
    /// </summary>
    public interface ORL_O36_SPECIMEN_CONTAINER :
        HL7V26Layout
    {
        /// <summary>
        /// SAC
        /// </summary>
        Segment<SAC> SAC { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<ORL_O36_ORDER> Order { get; }
    }
}