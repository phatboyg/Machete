namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface DG1Segment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<DateTimeOffset> DiagnosiCodingMethod { get; }
        Value<CWEComponent> DiagnosiCode { get; }
        Value<DateTimeOffset> DiagnosiDescription { get; }
        Value<DateTimeOffset> DiagnosiDateTime { get; }
        Value<string> DiagnosiType { get; }
    }
}