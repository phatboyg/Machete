namespace Machete.X12Schema.V5010
{
    using System;

    using Machete.X12;
    public interface DTM : X12Segment
    {
        Value<string> Qualifier { get; }

        Value<DateTime> Date { get; }
    }
}