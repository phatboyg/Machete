namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class IIIMap :
        X12SegmentMap<III, X12Entity>
    {
        public IIIMap()
        {
            Id = "III";
            Name = "Information";
            
            Value(x => x.CodeListQualifierCode, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.IndustryCode, 2, x => x.MinLength(1).MaxLength(30));
        }
    }
}