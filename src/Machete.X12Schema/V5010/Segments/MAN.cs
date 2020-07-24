namespace Machete.X12Schema.V5010
{
    using X12;


    public interface MAN :
        X12Segment
    {
        Value<string> MarksAndNumbersQualifier1 { get; }
        
        Value<string> MarksAndNumbers1 { get; }
        
        Value<string> MarksAndNumbers2 { get; }
        
        Value<string> MarksAndNumbersQualifier2 { get; }
        
        Value<string> MarksAndNumbers3 { get; }
        
        Value<string> MarksAndNumbers4 { get; }
    }
}