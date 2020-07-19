namespace Machete.X12Schema.V5010
{
    using X12;


    public interface RDM :
        X12Segment
    {
        Value<string> ReportTransmissionCode { get; }
        
        Value<string> Name { get; }
        
        Value<string> CommunicationNumber { get; }
    }
}