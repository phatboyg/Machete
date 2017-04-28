// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RTB_Z74 (MessageMap) - 
    /// </summary>
    public class RTB_Z74Map :
        HL7TemplateMap<RTB_Z74>
    {
        public RTB_Z74Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.ERR, 2);
            Map(x => x.SFT, 3);
            Map(x => x.UAC, 4);
            Map(x => x.QAK, 5, x => x.Required = true);
            Map(x => x.QPD, 6, x => x.Required = true);
            Map(x => x.RowDefinition, 7);
            Map(x => x.DSC, 8);
        }
    }
}