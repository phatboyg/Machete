// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O21_PRIOR_RESULT (GroupMap) - 
    /// </summary>
    public class OML_O21_PRIOR_RESULTMap :
        HL7V26LayoutMap<OML_O21_PRIOR_RESULT>
    {
        public OML_O21_PRIOR_RESULTMap()
        {
            Layout(x => x.PatientPrior, 0);
            Layout(x => x.PatientVisitPrior, 1);
            Segment(x => x.AL1, 2);
            Layout(x => x.OrderPrior, 3, x => x.Required = true);
        }
    }
}