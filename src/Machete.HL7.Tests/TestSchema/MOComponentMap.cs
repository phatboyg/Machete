namespace Machete.HL7.Tests.TestSchema
{
    public class MOComponentMap :
        HL7ComponentMap<MOComponent, HL7Component>
    {
        public MOComponentMap()
        {
            Value(x => x.Quantity, 0);
            Value(x => x.Denomination, 1);
        }
    }
}