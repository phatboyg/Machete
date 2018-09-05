// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CDM (SegmentMap) - Charge Description Master
    /// </summary>
    public class CDMMap :
        HL7V26SegmentMap<CDM>
    {
        public CDMMap()
        {
            Id = "CDM";

            Name = "Charge Description Master";

            Entity(x => x.PrimaryKeyValue, 1, x => x.IsRequired());
            Entity(x => x.ChargeCodeAlias, 2);
            Value(x => x.ChargeDescriptionShort, 3, x => x.IsRequired());
            Value(x => x.ChargeDescriptionLong, 4);
            Value(x => x.DescriptionOverrideIndicator, 5);
            Entity(x => x.ExplodingCharges, 6);
            Entity(x => x.ProcedureCode, 7);
            Value(x => x.ActiveInactiveFlag, 8);
            Entity(x => x.InventoryNumber, 9);
            Value(x => x.ResourceLoad, 10);
            Entity(x => x.ContractNumber, 11);
            Entity(x => x.ContractOrganization, 12);
            Value(x => x.RoomFeeIndicator, 13);
        }
    }
}