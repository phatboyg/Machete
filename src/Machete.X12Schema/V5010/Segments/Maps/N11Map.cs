namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class N11Map :
        X12SegmentMap<N11, X12Entity>
    {
        public N11Map()
        {
            Id = "N11";
            Name = "Store Number";
            
            Value(x => x.StoreNumber, 1, x => x.MinLength(1).MaxLength(10));
            Value(x => x.LocationIdentifier, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(30));
        }
    }
}