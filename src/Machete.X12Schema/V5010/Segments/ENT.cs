namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ENT :
        X12Segment
    {
        Value<string> AssignedNumber { get; }
        
        Value<string> EntityIdentifierCode1 { get; }
        
        Value<string> IdentificationCodeQualifier1 { get; }
        
        Value<string> IdentificationCode1 { get; }
        
        Value<string> EntityIdentifierCode2 { get; }
        
        Value<string> IdentificationCodeQualifier2 { get; }
        
        Value<string> IdentificationCode2 { get; }

        Value<string> ReferenceIdentificationQualifier { get; }

        Value<string> ReferenceIdentification { get; }
    }
}