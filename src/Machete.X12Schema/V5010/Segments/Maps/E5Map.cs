namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class E5Map :
        X12SegmentMap<E5, X12Entity>
    {
        public E5Map()
        {
            Id = "E5";
            Name = "Empty Car Disposition - Pended Destination Route";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.RoutingSequenceCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.CityName, 3, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StandardPointLocationCode, 4, x => x.MinLength(6).MaxLength(9));
        }
    }
}