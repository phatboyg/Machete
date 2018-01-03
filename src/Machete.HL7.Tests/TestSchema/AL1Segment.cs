namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface AL1Segment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<CWEComponent> AllergenTypeCode { get; }
        Value<CWEComponent> AllergenCodeMnemonicDescription { get; }
        Value<CWEComponent> AllergySeverityCode { get; }
        ValueList<string> AllergyReactionCode { get; }
        Value<DateTimeOffset> IdentificationDate { get; }
    }
}