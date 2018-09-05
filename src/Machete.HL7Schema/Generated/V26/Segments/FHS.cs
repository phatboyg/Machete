// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// FHS (Segment) - File Header
    /// </summary>
    public interface FHS :
        HL7V26Segment
    {
        /// <summary>
        /// FHS-1: File Field Separator
        /// </summary>
        Value<string> FileFieldSeparator { get; }

        /// <summary>
        /// FHS-2: File Encoding Characters
        /// </summary>
        Value<string> FileEncodingCharacters { get; }

        /// <summary>
        /// FHS-3: File Sending Application
        /// </summary>
        Value<HD> FileSendingApplication { get; }

        /// <summary>
        /// FHS-4: File Sending Facility
        /// </summary>
        Value<HD> FileSendingFacility { get; }

        /// <summary>
        /// FHS-5: File Receiving Application
        /// </summary>
        Value<HD> FileReceivingApplication { get; }

        /// <summary>
        /// FHS-6: File Receiving Facility
        /// </summary>
        Value<HD> FileReceivingFacility { get; }

        /// <summary>
        /// FHS-7: File Creation Date/Time
        /// </summary>
        Value<DateTimeOffset> FileCreationDateTime { get; }

        /// <summary>
        /// FHS-8: File Security
        /// </summary>
        Value<string> FileSecurity { get; }

        /// <summary>
        /// FHS-9: File Name/ID
        /// </summary>
        Value<string> FileNameId { get; }

        /// <summary>
        /// FHS-10: File Header Comment
        /// </summary>
        Value<string> FileHeaderComment { get; }

        /// <summary>
        /// FHS-11: File Control ID
        /// </summary>
        Value<string> FileControlId { get; }

        /// <summary>
        /// FHS-12: Reference File Control ID
        /// </summary>
        Value<string> ReferenceFileControlId { get; }

        /// <summary>
        /// FHS-13: File Sending Network Address
        /// </summary>
        Value<HD> FileSendingNetworkAddress { get; }

        /// <summary>
        /// FHS-14: File Receiving Network Address
        /// </summary>
        Value<HD> FileReceivingNetworkAddress { get; }
    }
}