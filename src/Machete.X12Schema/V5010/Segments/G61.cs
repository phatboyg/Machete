namespace Machete.X12Schema.V5010
{
    using X12;


    public interface G61 :
        X12Segment
    {
        Value<string> ContactFunctionCode { get; }
        
        Value<string> Name { get; }
        
        Value<string> CommunicationNumberQualifier { get; }
        
        Value<string> CommunicationNumber { get; }
        
        Value<string> ContactInquiryReference { get; }
    }
}