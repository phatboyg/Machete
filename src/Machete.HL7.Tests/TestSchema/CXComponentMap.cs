namespace Machete.HL7.Tests.TestSchema
{
    public class CXComponentMap :
        HL7ComponentMap<CXComponent, HL7Component>
    {
        public CXComponentMap()
        {
            Value(x => x.IdNumber, 0);
            Value(x => x.IdentifierCheckDigit, 1);
            Value(x => x.CheckDigitScheme, 2);
            Entity(x => x.AssigningAuthority, 3);
            Value(x => x.IdentifierTypeCode, 4);
            Entity(x => x.AssigningFacility, 5);
            Value(x => x.EffectiveDate, 6, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 7, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.AssigningJurisdiction, 8);
            Entity(x => x.AssigningAgencyOrDepartment, 9);
        }
    }
}