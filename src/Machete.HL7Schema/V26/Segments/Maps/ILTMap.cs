// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ILT (SegmentMap) - Material Lot
    /// </summary>
    public class ILTMap :
        HL7V26SegmentMap<ILT>
    {
        public ILTMap()
        {
            Id = "ILT";

            Name = "Material Lot";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.InventoryLotNumber, 2, x => x.IsRequired());
            Value(x => x.InventoryExpirationDate, 3, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.InventoryReceivedDate, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.InventoryReceivedQuantity, 5);
            Entity(x => x.InventoryReceivedQuantityUnit, 6);
            Entity(x => x.InventoryReceivedItemCost, 7);
            Value(x => x.InventoryOnHandDate, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.InventoryOnHandQuantity, 9);
            Entity(x => x.InventoryOnHandQuantityUnit, 10);
        }
    }
}