namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class LQMap :
        X12SegmentMap<LQ, X12Entity>
    {
        public LQMap()
        {
            Id = "LQ";
            Name = "Industry Code";
            
            Value(x => x.QualifierCode, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.IndustryCode, 2, x => x.MinLength(1).MaxLength(30).IsRequired());
        }
    }
}