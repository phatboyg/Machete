namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class E1Map :
        X12SegmentMap<E1, X12Entity>
    {
        public E1Map()
        {
            Id = "E1";
            Name = "Empty Car Disposition - Pended Destination Consignee";
            
            Value(x => x.Name, 1, x => x.MinLength(1).MaxLength(60).IsRequired());
            Value(x => x.IdentificationCodeQualifier, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IdentificationCode, 3, x => x.MinLength(2).MaxLength(80));
        }
    }
}