// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// BPO (Segment) - Blood product order
    /// </summary>
    public interface BPO :
        HL7V26Segment
    {
        /// <summary>
        /// BPO-1: Set ID - BPO
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// BPO-2: BP Universal Service Identifier
        /// </summary>
        Value<CWE> BPUniversalServiceIdentifier { get; }

        /// <summary>
        /// BPO-3: BP  Processing Requirements
        /// </summary>
        ValueList<CWE> BPProcessingRequirements { get; }

        /// <summary>
        /// BPO-4: BP Quantity
        /// </summary>
        Value<decimal> BPQuantity { get; }

        /// <summary>
        /// BPO-5: BP Amount
        /// </summary>
        Value<decimal> BPAmount { get; }

        /// <summary>
        /// BPO-6: BP Units
        /// </summary>
        Value<CWE> BPUnits { get; }

        /// <summary>
        /// BPO-7: BP Intended Use Date/Time
        /// </summary>
        Value<DateTimeOffset> BPIntendedUseDateTime { get; }

        /// <summary>
        /// BPO-8: BP Intended Dispense From Location
        /// </summary>
        Value<PL> BPIntendedDispenseFromLocation { get; }

        /// <summary>
        /// BPO-9: BP Intended Dispense From Address
        /// </summary>
        Value<XAD> BPIntendedDispenseFromAddress { get; }

        /// <summary>
        /// BPO-10: BP Requested Dispense Date/Time
        /// </summary>
        Value<DateTimeOffset> BPRequestedDispenseDateTime { get; }

        /// <summary>
        /// BPO-11: BP Requested Dispense To Location
        /// </summary>
        Value<PL> BPRequestedDispenseToLocation { get; }

        /// <summary>
        /// BPO-12: BP Requested Dispense To Address
        /// </summary>
        Value<XAD> BPRequestedDispenseToAddress { get; }

        /// <summary>
        /// BPO-13: BP Indication for Use
        /// </summary>
        ValueList<CWE> BPIndicationForUse { get; }

        /// <summary>
        /// BPO-14: BP Informed Consent Indicator
        /// </summary>
        Value<string> BPInformedConsentIndicator { get; }
    }
}