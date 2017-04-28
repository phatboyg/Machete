// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FC (ComponentMap) - Financial Class
    /// </summary>
    public class FCMap :
        HL7ComponentMap<FC>
    {
        public FCMap()
        {
            Value(x => x.FinancialClassCode, 1);
            Value(x => x.EffectiveDate, 2, x => {x.Format = "LONGDATETIME2";});
        }
    }
}