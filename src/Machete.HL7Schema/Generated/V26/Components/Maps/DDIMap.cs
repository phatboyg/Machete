// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DDI (ComponentMap) - Daily Deductible Information
    /// </summary>
    public class DDIMap :
        HL7V26ComponentMap<DDI>
    {
        public DDIMap()
        {
            Value(x => x.DelayDays, 0);
            Entity(x => x.MonetaryAmount, 1);
            Value(x => x.NumberOfDays, 2);
        }
    }
}