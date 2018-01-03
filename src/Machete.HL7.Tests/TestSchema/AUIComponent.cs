namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface AUIComponent :
        HL7Component
    {
        Value<string> AuthorizationNumber { get; }
        Value<DateTimeOffset> Date { get; }
        Value<string> Source { get; }
    }
}