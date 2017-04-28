// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRI_I12 (MessageMap) - 
    /// </summary>
    public class RRI_I12Map :
        HL7TemplateMap<RRI_I12>
    {
        public RRI_I12Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3);
            Map(x => x.RF1, 4);
            Map(x => x.AuthorizationContact, 5);
            Map(x => x.ProviderContact, 6, x => x.Required = true);
            Map(x => x.PID, 7, x => x.Required = true);
            Map(x => x.ACC, 8);
            Map(x => x.DG1, 9);
            Map(x => x.DRG, 10);
            Map(x => x.AL1, 11);
            Map(x => x.Procedure, 12);
            Map(x => x.Observation, 13);
            Map(x => x.PatientVisit, 14);
            Map(x => x.NTE, 15);
        }
    }
}