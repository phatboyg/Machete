// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTA (ComponentMap) - Policy Type and Amount
    /// </summary>
    public class PTAMap :
        HL7V26ComponentMap<PTA>
    {
        public PTAMap()
        {
            Value(x => x.PolicyType, 0);
            Value(x => x.AmountClass, 1);
            Value(x => x.MoneyOrPercentageQuantity, 2);
            Entity(x => x.MoneyOrPercentage, 3);
        }
    }
}