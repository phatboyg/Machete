namespace Machete.HL7.Tests.TestSchema
{
    public class OBRSegmentMap :
        HL7SegmentMap<OBRSegment, HL7Entity>
    {
        public OBRSegmentMap()
        {
            Id = "OBR";

            Name = "Observation Request";

            Value(x => x.SetId, 1);
            Entity(x => x.PlacerOrderNumber, 2);
            Entity(x => x.FillerOrderNumber, 3);
            Entity(x => x.UniversalServiceIdentifier, 4, x => { x.Required = true; });
            Value(x => x.Priority, 5);
            Value(x => x.RequestedDateTime, 6, x => x.LongDateTimeOffset());
            Value(x => x.ObservationDateTime, 7, x => x.LongDateTimeOffset());
            Value(x => x.ObservationEndDateTime, 8, x => x.LongDateTimeOffset());
        }
    }
}