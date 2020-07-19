// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// BTX (Segment) - Blood Product Transfusion/Disposition
    /// </summary>
    public interface BTX :
        HL7V26Segment
    {
        /// <summary>
        /// BTX-1: Set ID - BTX
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// BTX-2: BC Donation ID
        /// </summary>
        Value<EI> BCDonationId { get; }

        /// <summary>
        /// BTX-3: BC Component
        /// </summary>
        Value<CNE> BCComponent { get; }

        /// <summary>
        /// BTX-4: BC Blood Group
        /// </summary>
        Value<CNE> BCBloodGroup { get; }

        /// <summary>
        /// BTX-5: CP Commercial Product
        /// </summary>
        Value<CWE> CPCommercialProduct { get; }

        /// <summary>
        /// BTX-6: CP Manufacturer
        /// </summary>
        Value<XON> CPManufacturer { get; }

        /// <summary>
        /// BTX-7: CP Lot Number
        /// </summary>
        Value<EI> CPLotNumber { get; }

        /// <summary>
        /// BTX-8: BP Quantity
        /// </summary>
        Value<decimal> BPQuantity { get; }

        /// <summary>
        /// BTX-9: BP Amount
        /// </summary>
        Value<decimal> BPAmount { get; }

        /// <summary>
        /// BTX-10: BP Units
        /// </summary>
        Value<CWE> BPUnits { get; }

        /// <summary>
        /// BTX-11: BP Transfusion/Disposition Status
        /// </summary>
        Value<CWE> BPTransfusionDispositionStatus { get; }

        /// <summary>
        /// BTX-12: BP Message Status
        /// </summary>
        Value<string> BPMessageStatus { get; }

        /// <summary>
        /// BTX-13: BP Date/Time of Status
        /// </summary>
        Value<DateTimeOffset> BPDateTimeOfStatus { get; }

        /// <summary>
        /// BTX-14: BP Transfusion Administrator
        /// </summary>
        Value<XCN> BPTransfusionAdministrator { get; }

        /// <summary>
        /// BTX-15: BP Transfusion Verifier
        /// </summary>
        Value<XCN> BPTransfusionVerifier { get; }

        /// <summary>
        /// BTX-16: BP Transfusion Start Date/Time of Status
        /// </summary>
        Value<DateTimeOffset> BPTransfusionStartDateTimeOfStatus { get; }

        /// <summary>
        /// BTX-17: BP Transfusion End Date/Time of Status
        /// </summary>
        Value<DateTimeOffset> BPTransfusionEndDateTimeOfStatus { get; }

        /// <summary>
        /// BTX-18: BP Adverse Reaction Type
        /// </summary>
        ValueList<CWE> BPAdverseReactionType { get; }

        /// <summary>
        /// BTX-19: BP Transfusion Interrupted Reason
        /// </summary>
        Value<CWE> BPTransfusionInterruptedReason { get; }
    }
}