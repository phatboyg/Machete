namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class TA1Map : X12SegmentMap<TA1, X12Entity>
    {
        public TA1Map()
        {
            Id = "TA1";
            Name = "Interchange Acknowledgment";
            Value(x => x.InterchangeControlNumber, 1, x => x.MinLength(1));
            Value(x => x.InterchangeDate, 2, x => x.LongDate());
            Value(x => x.InterchangeTime, 3, x=> x.Time());
            Value(x => x.InterchangeAcknowledgmentCode, 4, x => x.MinLength(1));
            Value(x => x.InterchangeNoteCode, 5, x => x.MinLength(1));
        }
    }
}