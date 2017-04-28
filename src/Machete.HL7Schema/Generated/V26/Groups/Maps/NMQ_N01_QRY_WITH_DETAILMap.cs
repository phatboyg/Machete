// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMQ_N01_QRY_WITH_DETAIL (GroupMap) - 
    /// </summary>
    public class NMQ_N01_QRY_WITH_DETAILMap :
        HL7TemplateMap<NMQ_N01_QRY_WITH_DETAIL>
    {
        public NMQ_N01_QRY_WITH_DETAILMap()
        {
            Map(x => x.QRD, 0, x => x.Required = true);
            Map(x => x.QRF, 1);
        }
    }
}