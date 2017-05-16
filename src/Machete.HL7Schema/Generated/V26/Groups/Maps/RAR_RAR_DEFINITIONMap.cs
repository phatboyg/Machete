// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAR_RAR_DEFINITION (GroupMap) - 
    /// </summary>
    public class RAR_RAR_DEFINITIONMap :
        HL7LayoutMap<RAR_RAR_DEFINITION>
    {
        public RAR_RAR_DEFINITIONMap()
        {
            Segment(x => x.QRD, 0, x => x.Required = true);
            Segment(x => x.QRF, 1);
            Layout(x => x.Patient, 2);
            Layout(x => x.Order, 3, x => x.Required = true);
        }
    }
}