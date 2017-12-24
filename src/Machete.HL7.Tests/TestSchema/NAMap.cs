namespace Machete.HL7.Tests.TestSchema
{
    public class NAMap :
        HL7ComponentMap<NA, HL7Component>
    {
        public NAMap()
        {
            Value(x => x.Value1, 0);
            Value(x => x.Value2, 1);
            Value(x => x.Value3, 2);
            Value(x => x.Value4, 3);
        }
    }
}