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
        HL7V26LayoutMap<OPL_O37_PRIOR_RESULT>
    {
        public OPL_O37_PRIOR_RESULTMap()
        {
            Segment(x => x.NK1, 0, x => x.Required = true);
            Layout(x => x.PatientPrior, 1);
            Layout(x => x.PatientVisitPrior, 2);
            Segment(x => x.AL1, 3);
            Layout(x => x.OrderPrior, 4, x => x.Required = true);
        }
    }
}