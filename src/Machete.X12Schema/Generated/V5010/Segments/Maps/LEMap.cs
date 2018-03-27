namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class LEMap :
        X12SegmentMap<LE, X12Entity>
    {
        public LEMap()
        {
            Id = "LE";
            Name = "Loop Trailer";
            
            Value(x => x.LoopIdentifierCode, 1, x => x.FixedLength(1));
        }
    }
}