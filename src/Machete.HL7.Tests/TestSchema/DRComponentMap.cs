namespace Machete.HL7.Tests.TestSchema
{
    public class DRComponentMap :
        HL7ComponentMap<DRComponent, HL7Component>
    {
        public DRComponentMap()
        {
            Value(x => x.RangeStartDateTime, 0, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.RangeEndDateTime, 1, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
        }
    }
}