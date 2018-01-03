namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface FCComponent :
        HL7Component
    {
        Value<string> FinancialClassCode { get; }
        Value<DateTimeOffset> EffectiveDate { get; }
    }
}