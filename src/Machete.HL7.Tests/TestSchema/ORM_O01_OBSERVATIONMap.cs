namespace Machete.HL7.Tests.TestSchema
{
    public class ORM_O01_OBSERVATIONMap :
        HL7LayoutMap<ORM_O01_OBSERVATION, HL7Entity>
    {
        public ORM_O01_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.IsRequired());
            Segment(x => x.NTE, 1, x => x.IsOptional());
        }
    }
}