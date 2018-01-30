namespace Machete.X12Schema.V5010
{
    using X12;

    
    public interface PER :
        X12Segment
    {
        Value<string> ContactFunctionCode { get; }

        Value<string> Name { get; }

        Value<string> CommunicationNumberQualifier1 { get; }

        Value<string> CommunicationNumber1 { get; }

        Value<string> CommunicationNumberQualifier2 { get; }

        Value<string> CommunicationNumber2 { get; }

        Value<string> CommunicationNumberQualifier3 { get; }

        Value<string> CommunicationNumber3 { get; }
    }
}