// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// REF_I12 (MessageMap) - 
    /// </summary>
    public class REF_I12Map :
        HL7TemplateMap<REF_I12>
    {
        public REF_I12Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.RF1, 3);
            Map(x => x.AuthorizationContact, 4);
            Map(x => x.ProviderContact, 5, x => x.Required = true);
            Map(x => x.PID, 6, x => x.Required = true);
            Map(x => x.NK1, 7);
            Map(x => x.GT1, 8);
            Map(x => x.Insurance, 9);
            Map(x => x.ACC, 10);
            Map(x => x.DG1, 11);
            Map(x => x.DRG, 12);
            Map(x => x.AL1, 13);
            Map(x => x.Procedure, 14);
            Map(x => x.Observation, 15);
            Map(x => x.PatientVisit, 16);
            Map(x => x.NTE, 17);
        }
    }
}