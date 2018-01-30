namespace Machete.X12Schema.V5010
{
    using System;
    using X12;
    
    
    public interface TA1 :
        X12Segment
    {
        Value<int> InterchangeControlNumber { get; }

        Value<DateTime> InterchangeDate { get; }

        Value<DateTime> InterchangeTime { get; }

        Value<string> InterchangeAcknowledgmentCode { get; }

        Value<string> InterchangeNoteCode { get; }
    }
}