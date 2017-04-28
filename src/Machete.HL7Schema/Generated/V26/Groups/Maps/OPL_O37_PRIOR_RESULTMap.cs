// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_PRIOR_RESULT (GroupMap) - 
    /// </summary>
    public class OPL_O37_PRIOR_RESULTMap :
        HL7TemplateMap<OPL_O37_PRIOR_RESULT>
    {
        public OPL_O37_PRIOR_RESULTMap()
        {
            Map(x => x.NK1, 0, x => x.Required = true);
            Map(x => x.PatientPrior, 1);
            Map(x => x.PatientVisitPrior, 2);
            Map(x => x.AL1, 3);
            Map(x => x.OrderPrior, 4, x => x.Required = true);
        }
    }
}