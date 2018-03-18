namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class DN1Map :
        X12SegmentMap<DN1, X12Entity>
    {
        public DN1Map()
        {
            Id = "DN1";
            Name = "Orthodontic Total Months of Treatment";
            
            Value(x => x.Quantity1, 1, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Quantity2, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Description, 4, x => x.MinLength(1).MaxLength(80));
        }
    }
}