// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PCE (SegmentMap) - Patient Charge Cost Center Exceptions
    /// </summary>
    public class PCEMap :
        HL7V26SegmentMap<PCE>
    {
        public PCEMap()
        {
            Id = "PCE";

            Name = "Patient Charge Cost Center Exceptions";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.CostCenterAccountNumber, 2);
            Entity(x => x.TransactionCode, 3);
            Entity(x => x.TransactionAmountUnit, 4);
        }
    }
}