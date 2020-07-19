// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RCI_I05_PROVIDER (GroupMap) - 
    /// </summary>
    public class RCI_I05_PROVIDERMap :
        HL7V26LayoutMap<RCI_I05_PROVIDER>
    {
        public RCI_I05_PROVIDERMap()
        {
            Segment(x => x.PRD, 0, x => x.Required = true);
            Segment(x => x.CTD, 1);
        }
    }
}