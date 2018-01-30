namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class N3Map :
        X12SegmentMap<N3, X12Entity>
    {
        public N3Map()
        {
            Id = "N3";
            Name = "Address Information";
            
            Value(x => x.AddressInformation1, 1, x => x.MinLength(1).MaxLength(55).IsRequired());
            Value(x => x.AddressInformation2, 2, x => x.MinLength(1).MaxLength(55));
        }
    }
}