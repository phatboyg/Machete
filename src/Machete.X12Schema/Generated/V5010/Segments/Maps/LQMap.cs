namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class LQMap : X12SegmentMap<LQ, X12Entity>
    {
        public LQMap()
        {
            Id = "LQ";
            Name = "Industry Code";
            Value(x => x.Qualifier, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.RemarkCode, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
        }
    }
}