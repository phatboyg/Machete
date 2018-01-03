namespace Machete.HL7.Tests.TestSchema
{
    public class ORM_O01_ORDERMap :
        HL7LayoutMap<ORM_O01_ORDER, HL7Entity>
    {
        public ORM_O01_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.IsRequired());
            Layout(x => x.OrderDetail, 1, x => x.IsRequired());
        }
    }
}