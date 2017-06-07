// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RMC (ComponentMap) - Room Coverage
    /// </summary>
    public class RMCMap :
        HL7V26ComponentMap<RMC>
    {
        public RMCMap()
        {
            Value(x => x.RoomType, 0);
            Value(x => x.AmountType, 1);
            Value(x => x.CoverageAmount, 2);
            Entity(x => x.MoneyOrPercentage, 3);
        }
    }
}