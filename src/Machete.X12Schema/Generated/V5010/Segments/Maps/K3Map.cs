namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class K3Map :
        X12SegmentMap<K3, X12Entity>
    {
        public K3Map()
        {
            Id = "K3";
            Name = "File Information";
            
            Value(x => x.FixedFormatInformation, 1, x => x.MinLength(1).MaxLength(80).IsRequired());
        }
    }
}