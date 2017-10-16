namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class MSGMap : X12SegmentMap<MSG, X12Entity>
    {
        public MSGMap()
        {
            Id = "MSG";
            Name = "Message Text";
            Value(x => x.FreeFormMessageText, 1, x => x.MinLength(1));
        }
    }
}