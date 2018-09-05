// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// BHS (Segment) - Batch Header
    /// </summary>
    public interface BHS :
        HL7V26Segment
    {
        /// <summary>
        /// BHS-1: Batch Field Separator
        /// </summary>
        Value<string> BatchFieldSeparator { get; }

        /// <summary>
        /// BHS-2: Batch Encoding Characters
        /// </summary>
        Value<string> BatchEncodingCharacters { get; }

        /// <summary>
        /// BHS-3: Batch Sending Application
        /// </summary>
        Value<HD> BatchSendingApplication { get; }

        /// <summary>
        /// BHS-4: Batch Sending Facility
        /// </summary>
        Value<HD> BatchSendingFacility { get; }

        /// <summary>
        /// BHS-5: Batch Receiving Application
        /// </summary>
        Value<HD> BatchReceivingApplication { get; }

        /// <summary>
        /// BHS-6: Batch Receiving Facility
        /// </summary>
        Value<HD> BatchReceivingFacility { get; }

        /// <summary>
        /// BHS-7: Batch Creation Date/Time
        /// </summary>
        Value<DateTimeOffset> BatchCreationDateTime { get; }

        /// <summary>
        /// BHS-8: Batch Security
        /// </summary>
        Value<string> BatchSecurity { get; }

        /// <summary>
        /// BHS-9: Batch Name/ID/Type
        /// </summary>
        Value<string> BatchNameIdType { get; }

        /// <summary>
        /// BHS-10: Batch Comment
        /// </summary>
        Value<string> BatchComment { get; }

        /// <summary>
        /// BHS-11: Batch Control ID
        /// </summary>
        Value<string> BatchControlId { get; }

        /// <summary>
        /// BHS-12: Reference Batch Control ID
        /// </summary>
        Value<string> ReferenceBatchControlId { get; }

        /// <summary>
        /// BHS-13: Batch Sending Network Address
        /// </summary>
        Value<HD> BatchSendingNetworkAddress { get; }

        /// <summary>
        /// BHS-14: Batch Receiving Network Address
        /// </summary>
        Value<HD> BatchReceivingNetworkAddress { get; }
    }
}