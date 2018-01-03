namespace Machete.HL7.Tests.TestSchema
{
    public class ORM_O01_ORDER_DETAILMap :
        HL7LayoutMap<ORM_O01_ORDER_DETAIL, HL7Entity>
    {
        public ORM_O01_ORDER_DETAILMap()
        {
            Segment(x => x.OBR, 0, x => x.IsRequired());
            Segment(x => x.NTE, 1, x => x.IsOptional());
            Segment(x => x.DG1, 2, x => x.IsOptional());
            Layout(x => x.Observation, 3, x => x.IsOptional());
        }
    }
}