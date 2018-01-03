namespace Machete.HL7.Tests.TestSchema
{
    public class FNComponentMap :
        HL7ComponentMap<FNComponent, HL7Component>
    {
        public FNComponentMap()
        {
            Value(x => x.Surname, 0);
            Value(x => x.OwnSurnamePrefix, 1);
            Value(x => x.OwnSurname, 2);
            Value(x => x.SurnamePrefixFromPartnerSpouse, 3);
            Value(x => x.SurnameFromPartnerSpouse, 4);
        }
    }
}