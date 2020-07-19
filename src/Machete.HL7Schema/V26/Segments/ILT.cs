// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// ILT (Segment) - Material Lot
    /// </summary>
    public interface ILT :
        HL7V26Segment
    {
        /// <summary>
        /// ILT-1: Set Id - ILT
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// ILT-2: Inventory Lot Number
        /// </summary>
        Value<string> InventoryLotNumber { get; }

        /// <summary>
        /// ILT-3: Inventory Expiration Date
        /// </summary>
        Value<DateTimeOffset> InventoryExpirationDate { get; }

        /// <summary>
        /// ILT-4: Inventory Received Date
        /// </summary>
        Value<DateTimeOffset> InventoryReceivedDate { get; }

        /// <summary>
        /// ILT-5: Inventory Received Quantity
        /// </summary>
        Value<decimal> InventoryReceivedQuantity { get; }

        /// <summary>
        /// ILT-6: Inventory Received Quantity Unit
        /// </summary>
        Value<CWE> InventoryReceivedQuantityUnit { get; }

        /// <summary>
        /// ILT-7: Inventory Received Item Cost
        /// </summary>
        Value<MO> InventoryReceivedItemCost { get; }

        /// <summary>
        /// ILT-8: Inventory On Hand Date
        /// </summary>
        Value<DateTimeOffset> InventoryOnHandDate { get; }

        /// <summary>
        /// ILT-9: Inventory On Hand Quantity
        /// </summary>
        Value<decimal> InventoryOnHandQuantity { get; }

        /// <summary>
        /// ILT-10: Inventory On Hand Quantity Unit
        /// </summary>
        Value<CWE> InventoryOnHandQuantityUnit { get; }
    }
}