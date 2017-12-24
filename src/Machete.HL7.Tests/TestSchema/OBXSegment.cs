namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface OBXSegment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<string> ValueType { get; }
        Value<CWEComponent> ObservationIdentifier { get; }
        Value<string> ObservationSubId { get; }
        ValueList<string> ObservationValue { get; }
        Value<CWEComponent> Units { get; }
        Value<string> ReferenceRange { get; }
        ValueList<string> AbnormalFlags { get; }
        Value<decimal> Probability { get; }
        ValueList<string> NatureOfAbnormalTest { get; }
        Value<string> ObservationResultStatus { get; }
        Value<DateTimeOffset> EffectiveDateOfReferenceRange { get; }
        Value<string> UserDefinedAccessChecks { get; }
        Value<DateTimeOffset> DateTimeOfObservation { get; }
        Value<CWEComponent> ProducerSId { get; }
    }
}