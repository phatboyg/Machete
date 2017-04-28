// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// PES (Segment) - Product Experience Sender
    /// </summary>
    public interface PES :
        HL7Segment
    {
        /// <summary>
        /// PES-1: Sender Organization Name
        /// </summary>
        ValueList<XON> SenderOrganizationName { get; }

        /// <summary>
        /// PES-2: Sender Individual Name
        /// </summary>
        ValueList<XCN> SenderIndividualName { get; }

        /// <summary>
        /// PES-3: Sender Address
        /// </summary>
        ValueList<XAD> SenderAddress { get; }

        /// <summary>
        /// PES-4: Sender Telephone
        /// </summary>
        ValueList<XTN> SenderTelephone { get; }

        /// <summary>
        /// PES-5: Sender Event Identifier
        /// </summary>
        Value<EI> SenderEventIdentifier { get; }

        /// <summary>
        /// PES-6: Sender Sequence Number
        /// </summary>
        Value<decimal> SenderSequenceNumber { get; }

        /// <summary>
        /// PES-7: Sender Event Description
        /// </summary>
        ValueList<FT> SenderEventDescription { get; }

        /// <summary>
        /// PES-8: Sender Comment
        /// </summary>
        Value<FT> SenderComment { get; }

        /// <summary>
        /// PES-9: Sender Aware Date/Time
        /// </summary>
        Value<DateTimeOffset> SenderAwareDateTime { get; }

        /// <summary>
        /// PES-10: Event Report Date
        /// </summary>
        Value<DateTimeOffset> EventReportDate { get; }

        /// <summary>
        /// PES-11: Event Report Timing/Type
        /// </summary>
        Value<string> EventReportTimingType { get; }

        /// <summary>
        /// PES-12: Event Report Source
        /// </summary>
        Value<string> EventReportSource { get; }

        /// <summary>
        /// PES-13: Event Reported To
        /// </summary>
        ValueList<string> EventReportedTo { get; }
    }
}