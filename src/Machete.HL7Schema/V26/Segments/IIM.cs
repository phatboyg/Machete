// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// IIM (Segment) - Inventory Item Master
    /// </summary>
    public interface IIM :
        HL7V26Segment
    {
        /// <summary>
        /// IIM-1: Primary Key Value - IIM
        /// </summary>
        Value<CWE> PrimaryKeyValue { get; }

        /// <summary>
        /// IIM-2: Service Item Code
        /// </summary>
        Value<CWE> ServiceItemCode { get; }

        /// <summary>
        /// IIM-3: Inventory Lot Number
        /// </summary>
        Value<string> InventoryLotNumber { get; }

        /// <summary>
        /// IIM-4: Inventory Expiration Date
        /// </summary>
        Value<DateTimeOffset> InventoryExpirationDate { get; }

        /// <summary>
        /// IIM-5: Inventory Manufacturer Name
        /// </summary>
        Value<CWE> InventoryManufacturerName { get; }

        /// <summary>
        /// IIM-6: Inventory Location
        /// </summary>
        Value<CWE> InventoryLocation { get; }

        /// <summary>
        /// IIM-7: Inventory Received Date
        /// </summary>
        Value<DateTimeOffset> InventoryReceivedDate { get; }

        /// <summary>
        /// IIM-8: Inventory Received Quantity
        /// </summary>
        Value<decimal> InventoryReceivedQuantity { get; }

        /// <summary>
        /// IIM-9: Inventory Received Quantity Unit
        /// </summary>
        Value<CWE> InventoryReceivedQuantityUnit { get; }

        /// <summary>
        /// IIM-10: Inventory Received Item Cost
        /// </summary>
        Value<MO> InventoryReceivedItemCost { get; }

        /// <summary>
        /// IIM-11: Inventory On Hand Date
        /// </summary>
        Value<DateTimeOffset> InventoryOnHandDate { get; }

        /// <summary>
        /// IIM-12: Inventory On Hand Quantity
        /// </summary>
        Value<decimal> InventoryOnHandQuantity { get; }

        /// <summary>
        /// IIM-13: Inventory On Hand Quantity Unit
        /// </summary>
        Value<CWE> InventoryOnHandQuantityUnit { get; }

        /// <summary>
        /// IIM-14: Procedure Code
        /// </summary>
        Value<CNE> ProcedureCode { get; }

        /// <summary>
        /// IIM-15: Procedure Code Modifier
        /// </summary>
        ValueList<CNE> ProcedureCodeModifier { get; }
    }
}