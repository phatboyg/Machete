namespace Machete.HL7.Tests.TestSchema
{
    public class FCComponentMap :
        HL7ComponentMap<FCComponent, HL7Component>
    {
        public FCComponentMap()
        {
            Value(x => x.FinancialClassCode, 0);
            Value(x => x.EffectiveDate, 1, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
        }
    }
}