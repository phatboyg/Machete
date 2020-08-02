namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class W6Map :
        X12SegmentMap<W6, X12Entity>
    {
        public W6Map()
        {
            Id = "W6";
            Name = "Special Handling Information";
            
            Value(x => x.SpecialHandlingCode1, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.SpecialHandlingCode2, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.SpecialHandlingCode3, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.SpecialHandlingCode4, 4, x => x.MinLength(2).MaxLength(3));
        }
    }
}