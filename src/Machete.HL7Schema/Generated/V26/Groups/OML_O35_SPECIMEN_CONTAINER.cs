// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O35_SPECIMEN_CONTAINER (Group) - 
    /// </summary>
    public interface OML_O35_SPECIMEN_CONTAINER :
        HL7Layout
    {
        /// <summary>
        /// SAC
        /// </summary>
        Segment<SAC> SAC { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<OML_O35_ORDER> Order { get; }
    }
}