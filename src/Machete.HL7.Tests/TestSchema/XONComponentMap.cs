namespace Machete.HL7.Tests.TestSchema
{
    public class XONComponentMap :
        HL7ComponentMap<XONComponent, HL7Component>
    {
        public XONComponentMap()
        {
            Value(x => x.OrganizationName, 0);
            Value(x => x.OrganizationNameTypeCode, 1);
            Value(x => x.IdNumber, 2);
            Value(x => x.IdentifierCheckDigit, 3);
            Value(x => x.CheckDigitScheme, 4);
            Entity(x => x.AssigningAuthority, 5);
            Value(x => x.IdentifierTypeCode, 6);
            Entity(x => x.AssigningFacility, 7);
            Value(x => x.NameRepresentationCode, 8);
            Value(x => x.OrganizationIdentifier, 9);
        }
    }
}