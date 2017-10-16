namespace Machete.X12Schema.V5010
{
    using System;

    using Machete.X12;
    public interface FRM : X12Segment
    {
        Value<string> QuestionNumberLetter { get; }

        Value<string> ResponseCode { get; }

        Value<string> ResponseIdentification { get; }

        Value<DateTime> Date { get; }

        Value<decimal> Percent { get; }
    }
}