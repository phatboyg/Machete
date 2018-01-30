namespace Machete.X12.Schema.Segments
{
    using System;


    public interface ISA :
        X12Segment
    {
        Value<string> AuthorizationInformationQualifier { get; }
        
        Value<string> AuthorizationInformation { get; }
        
        Value<string> SecurityInformationQualifier { get; }
        
        Value<string> SecurityInformation { get; }
        
        Value<string> SenderIdQualifier { get; }
        
        Value<string> SenderId { get; }
        
        Value<string> ReceiverIdQualifier { get; }
        
        Value<string> ReceiverId { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> StandardsIdentifier { get; }
        
        Value<string> VersionNumber { get; }
        
        Value<int> ControlNumber { get; }
        
        Value<string> AcknowledgmentRequested { get; }
        
        Value<string> UsageIndicator { get; }
    }
}