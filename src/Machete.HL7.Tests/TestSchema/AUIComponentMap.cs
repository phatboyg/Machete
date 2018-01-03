namespace Machete.HL7.Tests.TestSchema
{
    public class AUIComponentMap :
        HL7ComponentMap<AUIComponent, HL7Component>
    {
        public AUIComponentMap()
        {
            Value(x => x.AuthorizationNumber, 0);
            Value(x => x.Date, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.Source, 2);
        }
    }
}