// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// RQD (Segment) - Requisition Detail
    /// </summary>
    public interface RQD :
        HL7V26Segment
    {
        /// <summary>
        /// RQD-1: Requisition Line Number
        /// </summary>
        Value<int> RequisitionLineNumber { get; }

        /// <summary>
        /// RQD-2: Item Code - Internal
        /// </summary>
        Value<CWE> ItemCodeInternal { get; }

        /// <summary>
        /// RQD-3: Item Code - External
        /// </summary>
        Value<CWE> ItemCodeExternal { get; }

        /// <summary>
        /// RQD-4: Hospital Item Code
        /// </summary>
        Value<CWE> HospitalItemCode { get; }

        /// <summary>
        /// RQD-5: Requisition Quantity
        /// </summary>
        Value<decimal> RequisitionQuantity { get; }

        /// <summary>
        /// RQD-6: Requisition Unit of Measure
        /// </summary>
        Value<CWE> RequisitionUnitOfMeasure { get; }

        /// <summary>
        /// RQD-7: Cost Center Account Number
        /// </summary>
        Value<string> CostCenterAccountNumber { get; }

        /// <summary>
        /// RQD-8: Item Natural Account Code
        /// </summary>
        Value<string> ItemNaturalAccountCode { get; }

        /// <summary>
        /// RQD-9: Deliver To ID
        /// </summary>
        Value<CWE> DeliverToId { get; }

        /// <summary>
        /// RQD-10: Date Needed
        /// </summary>
        Value<DateTimeOffset> DateNeeded { get; }
    }
}