namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class N2Map :
        X12SegmentMap<N2, X12Entity>
    {
        public N2Map()
        {
            Id = "N2";
            Name = "Additional Name Information";
            
            Value(x => x.Name, 1, x => x.MinLength(1).MaxLength(60).IsRequired());
        }
    }
}