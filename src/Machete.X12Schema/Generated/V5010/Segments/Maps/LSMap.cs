namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class LSMap : X12SegmentMap<LS, X12Entity>
    {
        public LSMap()
        {
            Id = "LS";
            Name = "Loop Header";
            Value(x => x.LoopIdentifierCode, 1, x => x.MinLength(1));
        }
    }
}