// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O33 (MessageMap) - 
    /// </summary>
    public class OML_O33Map :
        HL7TemplateMap<OML_O33>
    {
        public OML_O33Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.NTE, 3);
            Map(x => x.Patient, 4);
            Map(x => x.Specimen, 5, x => x.Required = true);
        }
    }
}