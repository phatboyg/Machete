// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// INV (SegmentMap) - Inventory Detail
    /// </summary>
    public class INVMap :
        HL7V26SegmentMap<INV>
    {
        public INVMap()
        {
            Id = "INV";

            Name = "Inventory Detail";

            Entity(x => x.SubstanceIdentifier, 1, x => x.IsRequired());
            Entity(x => x.SubstanceStatus, 2, x => x.IsRequired());
            Entity(x => x.SubstanceType, 3);
            Entity(x => x.InventoryContainerIdentifier, 4);
            Entity(x => x.ContainerCarrierIdentifier, 5);
            Entity(x => x.PositionOnCarrier, 6);
            Value(x => x.InitialQuantity, 7);
            Value(x => x.CurrentQuantity, 8);
            Value(x => x.AvailableQuantity, 9);
            Value(x => x.ConsumptionQuantity, 10);
            Entity(x => x.QuantityUnits, 11);
            Value(x => x.ExpirationDateTime, 12, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.FirstUsedDateTime, 13, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.OnBoardStabilityDuration, 14);
            Entity(x => x.TestFluidIdentifierS, 15);
            Value(x => x.ManufacturerLotNumber, 16);
            Entity(x => x.ManufacturerIdentifier, 17);
            Entity(x => x.SupplierIdentifier, 18);
            Entity(x => x.OnBoardStabilityTime, 19);
            Entity(x => x.TargetValue, 20);
        }
    }
}