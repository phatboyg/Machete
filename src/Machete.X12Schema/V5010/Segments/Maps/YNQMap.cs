namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class YNQMap :
        X12SegmentMap<YNQ, X12Entity>
    {
        public YNQMap()
        {
            Id = "YNQ";
            Name = "Yes/No Question";
            
            Value(x => x.ConditionIndicator, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.YesNoConditionOrResponseCode, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.DateTimePeriodFormatQualifier, 3, x => x.MinLength(2).MaxLength(3));
            Value(x => x.DateTimePeriod, 4, x => x.Converter = X12ValueConverters.DateTimePeriod);
            Value(x => x.MessageText1, 5, x => x.MinLength(1).MaxLength(264));
            Value(x => x.MessageText2, 6, x => x.MinLength(1).MaxLength(264));
            Value(x => x.MessageText3, 7, x => x.MinLength(1).MaxLength(264));
            Value(x => x.CodeListQualifierCode, 8, x => x.MinLength(1).MaxLength(3));
            Value(x => x.IndustryCode, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.MessageText4, 10, x => x.MinLength(1).MaxLength(264));
        }
    }
}