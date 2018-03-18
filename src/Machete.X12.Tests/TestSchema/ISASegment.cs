namespace Machete.X12.Tests.TestSchema
{
    using System;


    public interface ISASegment :
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