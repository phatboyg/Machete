namespace Machete.HL7.Tests.Segments
{
    public class HDComponentMap :
        HL7ComponentMap<HDComponent, HL7Component>
    {
        public HDComponentMap()
        {
            Value(x => x.NamespaceId, 0);
            Value(x => x.UniversalId, 1);
            Value(x => x.UniversalIdType, 2);
        }
    }
}