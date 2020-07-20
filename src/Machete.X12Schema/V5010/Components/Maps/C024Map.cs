namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C024Map :
        X12ComponentMap<C024, X12Entity>
    {
        public C024Map()
        {
            Value(x => x.RelatedCauseCode1, 0, x => x.MinLength(2).MaxLength(3));
            Value(x => x.RelatedCauseCode2, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.RelatedCauseCode3, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.AutoAccidentStateOrProvinceCode, 3, x => x.FixedLength(2));
            Value(x => x.CountryCode, 4, x => x.MinLength(2).MaxLength(3));
        }
    }
}