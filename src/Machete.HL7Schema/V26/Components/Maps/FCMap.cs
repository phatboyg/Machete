namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FC (ComponentMap) - Financial Class
    /// </summary>
    public class FCMap :
        HL7V26ComponentMap<FC>
    {
        public FCMap()
        {
            Value(x => x.FinancialClassCode, 0);
            Value(x => x.EffectiveDate, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}