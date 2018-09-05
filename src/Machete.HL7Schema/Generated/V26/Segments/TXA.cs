// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// TXA (Segment) - Transcription Document Header
    /// </summary>
    public interface TXA :
        HL7V26Segment
    {
        /// <summary>
        /// TXA-1: Set ID- TXA
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// TXA-2: Document Type
        /// </summary>
        Value<string> DocumentType { get; }

        /// <summary>
        /// TXA-3: Document Content Presentation
        /// </summary>
        Value<string> DocumentContentPresentation { get; }

        /// <summary>
        /// TXA-4: Activity Date/Time
        /// </summary>
        Value<DateTimeOffset> ActivityDateTime { get; }

        /// <summary>
        /// TXA-5: Primary Activity Provider Code/Name
        /// </summary>
        ValueList<XCN> PrimaryActivityProviderCodeName { get; }

        /// <summary>
        /// TXA-6: Origination Date/Time
        /// </summary>
        Value<DateTimeOffset> OriginationDateTime { get; }

        /// <summary>
        /// TXA-7: Transcription Date/Time
        /// </summary>
        Value<DateTimeOffset> TranscriptionDateTime { get; }

        /// <summary>
        /// TXA-8: Edit Date/Time
        /// </summary>
        ValueList<DateTimeOffset> EditDateTime { get; }

        /// <summary>
        /// TXA-9: Originator Code/Name
        /// </summary>
        ValueList<XCN> OriginatorCodeName { get; }

        /// <summary>
        /// TXA-10: Assigned Document Authenticator
        /// </summary>
        ValueList<XCN> AssignedDocumentAuthenticator { get; }

        /// <summary>
        /// TXA-11: Transcriptionist Code/Name
        /// </summary>
        ValueList<XCN> TranscriptionistCodeName { get; }

        /// <summary>
        /// TXA-12: Unique Document Number
        /// </summary>
        Value<EI> UniqueDocumentNumber { get; }

        /// <summary>
        /// TXA-13: Parent Document Number
        /// </summary>
        Value<EI> ParentDocumentNumber { get; }

        /// <summary>
        /// TXA-14: Placer Order Number
        /// </summary>
        ValueList<EI> PlacerOrderNumber { get; }

        /// <summary>
        /// TXA-15: Filler Order Number
        /// </summary>
        Value<EI> FillerOrderNumber { get; }

        /// <summary>
        /// TXA-16: Unique Document File Name
        /// </summary>
        Value<string> UniqueDocumentFileName { get; }

        /// <summary>
        /// TXA-17: Document Completion Status
        /// </summary>
        Value<string> DocumentCompletionStatus { get; }

        /// <summary>
        /// TXA-18: Document Confidentiality Status
        /// </summary>
        Value<string> DocumentConfidentialityStatus { get; }

        /// <summary>
        /// TXA-19: Document Availability Status
        /// </summary>
        Value<string> DocumentAvailabilityStatus { get; }

        /// <summary>
        /// TXA-20: Document Storage Status
        /// </summary>
        Value<string> DocumentStorageStatus { get; }

        /// <summary>
        /// TXA-21: Document Change Reason
        /// </summary>
        Value<string> DocumentChangeReason { get; }

        /// <summary>
        /// TXA-22: Authentication Person, Time Stamp (set)
        /// </summary>
        ValueList<PPN> AuthenticationPersonTimeStampSet { get; }

        /// <summary>
        /// TXA-23: Distributed Copies (Code and Name of Recipient(s) )
        /// </summary>
        ValueList<XCN> DistributedCopies { get; }
    }
}