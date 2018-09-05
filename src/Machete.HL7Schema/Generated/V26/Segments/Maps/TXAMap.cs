// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TXA (SegmentMap) - Transcription Document Header
    /// </summary>
    public class TXAMap :
        HL7V26SegmentMap<TXA>
    {
        public TXAMap()
        {
            Id = "TXA";

            Name = "Transcription Document Header";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Value(x => x.DocumentType, 2, x => {x.Required = true;});
            Value(x => x.DocumentContentPresentation, 3);
            Value(x => x.ActivityDateTime, 4, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.PrimaryActivityProviderCodeName, 5);
            Value(x => x.OriginationDateTime, 6, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.TranscriptionDateTime, 7, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EditDateTime, 8, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.OriginatorCodeName, 9);
            Entity(x => x.AssignedDocumentAuthenticator, 10);
            Entity(x => x.TranscriptionistCodeName, 11);
            Entity(x => x.UniqueDocumentNumber, 12, x => {x.Required = true;});
            Entity(x => x.ParentDocumentNumber, 13);
            Entity(x => x.PlacerOrderNumber, 14);
            Entity(x => x.FillerOrderNumber, 15);
            Value(x => x.UniqueDocumentFileName, 16);
            Value(x => x.DocumentCompletionStatus, 17, x => {x.Required = true;});
            Value(x => x.DocumentConfidentialityStatus, 18);
            Value(x => x.DocumentAvailabilityStatus, 19);
            Value(x => x.DocumentStorageStatus, 20);
            Value(x => x.DocumentChangeReason, 21);
            Entity(x => x.AuthenticationPersonTimeStampSet, 22);
            Entity(x => x.DistributedCopies, 23);
        }
    }
}