namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface GS :
        X12Segment
    {
        Value<string> FunctionalIdentifierCode { get; }
        
        Value<string> ApplicationSendersCode { get; }
        
        Value<string> ApplicationReceiversCode { get; }
        
        Value<DateTime> Date { get; }
        
        Value<int> ControlNumber { get; }
        
        Value<string> ResponsibleAgencyCode { get; }
        
        Value<string> VersionIdentifierCode { get; }
    }
}