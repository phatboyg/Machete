namespace Machete.HL7.Tests.TestSchema
{
    public class SADComponentMap :
        HL7ComponentMap<SADComponent, HL7Component>
    {
        public SADComponentMap()
        {
            Value(x => x.StreetOrMailingAddress, 0);
            Value(x => x.StreetName, 1);
            Value(x => x.DwellingNumber, 2);
        }
    }
}