namespace Machete.X12Schema.V5010
{
    using X12;


    public interface E1 :
        X12Segment
    {
        Value<string> Name { get; }
        
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode { get; }
    }
}