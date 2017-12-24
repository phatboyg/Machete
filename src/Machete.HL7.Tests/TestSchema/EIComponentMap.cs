namespace Machete.HL7.Tests.TestSchema
{
    public class EIComponentMap :
        HL7ComponentMap<EIComponent, HL7Component>
    {
        public EIComponentMap()
        {
            Value(x => x.EntityIdentifier, 0);
            Value(x => x.NamespaceId, 1);
            Value(x => x.UniversalId, 2);
            Value(x => x.UniversalIdType, 3);
        }
    }
}