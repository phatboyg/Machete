namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class LEMap : X12SegmentMap<LE, X12Entity>
    {
        public LEMap()
        {
            Id = "LE";
            Name = "Loop Trailer";
            Value(x => x.LoopIdentifierCode, 1, x => x.MinLength(1));
        }
    }
}