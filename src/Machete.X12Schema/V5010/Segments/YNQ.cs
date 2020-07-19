namespace Machete.X12Schema.V5010
{
    using X12;


    public interface YNQ :
        X12Segment
    {
        Value<string> ConditionIndicator { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<string> DateTimePeriodFormatQualifier { get; }
        
        Value<DateTimePeriod> DateTimePeriod { get; }
        
        Value<string> MessageText1 { get; }
        
        Value<string> MessageText2 { get; }
        
        Value<string> MessageText3 { get; }
        
        Value<string> CodeListQualifierCode { get; }
        
        Value<string> IndustryCode { get; }
        
        Value<string> MessageText4 { get; }
    }
}