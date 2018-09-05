// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// INV (Segment) - Inventory Detail
    /// </summary>
    public interface INV :
        HL7V26Segment
    {
        /// <summary>
        /// INV-1: Substance Identifier
        /// </summary>
        Value<CWE> SubstanceIdentifier { get; }

        /// <summary>
        /// INV-2: Substance Status
        /// </summary>
        ValueList<CWE> SubstanceStatus { get; }

        /// <summary>
        /// INV-3: Substance Type
        /// </summary>
        Value<CWE> SubstanceType { get; }

        /// <summary>
        /// INV-4: Inventory Container Identifier
        /// </summary>
        Value<CWE> InventoryContainerIdentifier { get; }

        /// <summary>
        /// INV-5: Container Carrier Identifier
        /// </summary>
        Value<CWE> ContainerCarrierIdentifier { get; }

        /// <summary>
        /// INV-6: Position on Carrier
        /// </summary>
        Value<CWE> PositionOnCarrier { get; }

        /// <summary>
        /// INV-7: Initial Quantity
        /// </summary>
        Value<decimal> InitialQuantity { get; }

        /// <summary>
        /// INV-8: Current Quantity
        /// </summary>
        Value<decimal> CurrentQuantity { get; }

        /// <summary>
        /// INV-9: Available Quantity
        /// </summary>
        Value<decimal> AvailableQuantity { get; }

        /// <summary>
        /// INV-10: Consumption Quantity
        /// </summary>
        Value<decimal> ConsumptionQuantity { get; }

        /// <summary>
        /// INV-11: Quantity Units
        /// </summary>
        Value<CWE> QuantityUnits { get; }

        /// <summary>
        /// INV-12: Expiration Date/Time
        /// </summary>
        Value<DateTimeOffset> ExpirationDateTime { get; }

        /// <summary>
        /// INV-13: First Used Date/Time
        /// </summary>
        Value<DateTimeOffset> FirstUsedDateTime { get; }

        /// <summary>
        /// INV-14: On Board Stability Duration
        /// </summary>
        Value<TQ> OnBoardStabilityDuration { get; }

        /// <summary>
        /// INV-15: Test/Fluid Identifier(s)
        /// </summary>
        ValueList<CWE> TestFluidIdentifierS { get; }

        /// <summary>
        /// INV-16: Manufacturer Lot Number
        /// </summary>
        Value<string> ManufacturerLotNumber { get; }

        /// <summary>
        /// INV-17: Manufacturer Identifier
        /// </summary>
        Value<CWE> ManufacturerIdentifier { get; }

        /// <summary>
        /// INV-18: Supplier Identifier
        /// </summary>
        Value<CWE> SupplierIdentifier { get; }

        /// <summary>
        /// INV-19: On Board Stability Time
        /// </summary>
        Value<CQ> OnBoardStabilityTime { get; }

        /// <summary>
        /// INV-20: Target Value
        /// </summary>
        Value<CQ> TargetValue { get; }
    }
}