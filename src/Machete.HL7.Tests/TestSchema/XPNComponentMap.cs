namespace Machete.HL7.Tests.TestSchema
{
    public class XPNComponentMap :
        HL7ComponentMap<XPNComponent, HL7Component>
    {
        public XPNComponentMap()
        {
            Entity(x => x.FamilyName, 0);
            Value(x => x.GivenName, 1);
            Value(x => x.SecondAndFurtherGivenNamesOrInitialsreof, 2);
            Value(x => x.Suffix, 3);
            Value(x => x.Prefix, 4);
            Value(x => x.Degree, 5);
            Value(x => x.NameTypeCode, 6);
            Value(x => x.NameRepresentationCode, 7);
            Entity(x => x.NameContext, 8);
            Entity(x => x.NameValidityRange, 9);
            Value(x => x.NameAssemblyOrder, 10);
            Value(x => x.EffectiveDate, 11, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 12, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ProfessionalSuffix, 13);
        }
    }
}