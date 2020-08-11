namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class PRSMap :
        X12SegmentMap<PRS, X12Entity>
    {
        public PRSMap()
        {
            Id = "PRS";
            Name = "Part Release Status";
            
            Value(x => x.PartReleaseStatusCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Description, 2, x => x.MinLength(1).MaxLength(80));
        }
    }
}