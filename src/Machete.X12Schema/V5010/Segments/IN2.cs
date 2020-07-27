namespace Machete.X12Schema.V5010
{
    using X12;


    public interface IN2 :
        X12Segment
    {
        Value<string> NameComponentQualifier { get; }
        
        Value<string> Name1 { get; }
        
        Value<string> Name2 { get; }
    }
}