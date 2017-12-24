namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface OBRSegment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<EIComponent> PlacerOrderNumber { get; }
        Value<EIComponent> FillerOrderNumber { get; }
        Value<CWEComponent> UniversalServiceIdentifier { get; }
        Value<string> Priority { get; }
        Value<DateTimeOffset> RequestedDateTime { get; }
        Value<DateTimeOffset> ObservationDateTime { get; }
        Value<DateTimeOffset> ObservationEndDateTime { get; }
    }
}