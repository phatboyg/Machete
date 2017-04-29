// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01_PROCEDURE (GroupMap) - 
    /// </summary>
    public class EHC_E01_PROCEDUREMap :
        HL7TemplateMap<EHC_E01_PROCEDURE>
    {
        public EHC_E01_PROCEDUREMap()
        {
            Segment(x => x.PR1, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.ROL, 2);
        }
    }
}