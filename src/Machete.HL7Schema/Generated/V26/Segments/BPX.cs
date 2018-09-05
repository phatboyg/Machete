// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// BPX (Segment) - Blood product dispense status
    /// </summary>
    public interface BPX :
        HL7V26Segment
    {
        /// <summary>
        /// BPX-1: Set ID - BPX
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// BPX-2: BP Dispense Status
        /// </summary>
        Value<CWE> BPDispenseStatus { get; }

        /// <summary>
        /// BPX-3: BP Status
        /// </summary>
        Value<string> BPStatus { get; }

        /// <summary>
        /// BPX-4: BP Date/Time of Status
        /// </summary>
        Value<DateTimeOffset> BPDateTimeOfStatus { get; }

        /// <summary>
        /// BPX-5: BC Donation ID
        /// </summary>
        Value<EI> BCDonationId { get; }

        /// <summary>
        /// BPX-6: BC Component
        /// </summary>
        Value<CNE> BCComponent { get; }

        /// <summary>
        /// BPX-7: BC Donation Type / Intended Use
        /// </summary>
        Value<CNE> BCDonationTypeIntendedUse { get; }

        /// <summary>
        /// BPX-8: CP Commercial Product
        /// </summary>
        Value<CWE> CPCommercialProduct { get; }

        /// <summary>
        /// BPX-9: CP Manufacturer
        /// </summary>
        Value<XON> CPManufacturer { get; }

        /// <summary>
        /// BPX-10: CP Lot Number
        /// </summary>
        Value<EI> CPLotNumber { get; }

        /// <summary>
        /// BPX-11: BP Blood Group
        /// </summary>
        Value<CNE> BPBloodGroup { get; }

        /// <summary>
        /// BPX-12: BC Special Testing
        /// </summary>
        ValueList<CNE> BCSpecialTesting { get; }

        /// <summary>
        /// BPX-13: BP Expiration Date/Time
        /// </summary>
        Value<DateTimeOffset> BPExpirationDateTime { get; }

        /// <summary>
        /// BPX-14: BP Quantity
        /// </summary>
        Value<decimal> BPQuantity { get; }

        /// <summary>
        /// BPX-15: BP Amount
        /// </summary>
        Value<decimal> BPAmount { get; }

        /// <summary>
        /// BPX-16: BP Units
        /// </summary>
        Value<CWE> BPUnits { get; }

        /// <summary>
        /// BPX-17: BP Unique ID
        /// </summary>
        Value<EI> BPUniqueId { get; }

        /// <summary>
        /// BPX-18: BP Actual Dispensed To Location
        /// </summary>
        Value<PL> BPActualDispensedToLocation { get; }

        /// <summary>
        /// BPX-19: BP Actual Dispensed To Address
        /// </summary>
        Value<XAD> BPActualDispensedToAddress { get; }

        /// <summary>
        /// BPX-20: BP Dispensed to Receiver
        /// </summary>
        Value<XCN> BPDispensedToReceiver { get; }

        /// <summary>
        /// BPX-21: BP Dispensing Individual
        /// </summary>
        Value<XCN> BPDispensingIndividual { get; }
    }
}