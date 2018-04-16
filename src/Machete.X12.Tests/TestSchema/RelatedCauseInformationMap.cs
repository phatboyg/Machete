namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class RelatedCauseInformationMap :
        X12ComponentMap<RelatedCauseInformation, X12Entity>
    {
        public RelatedCauseInformationMap()
        {
            Value(x => x.RelatedCauseCode1, 0, x => x.MinLength(2).MaxLength(3));
            Value(x => x.RelatedCauseCode2, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.RelatedCauseCode3, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.AutoAccidentStateOrProvinceCode, 3, x => x.FixedLength(2));
            Value(x => x.CountryCode, 4, x => x.MinLength(2).MaxLength(3));
        }
    }
}