namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RYL :
        X12Segment
    {
        Value<int> AssignedNumber { get; }
        
        Value<string> NameLastOrOrganizationName { get; }
        
        Value<string> IdentificationCodeQualifier { get; }
        
        Value<string> IdentificationCode { get; }
    }
 }