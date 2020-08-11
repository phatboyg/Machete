namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface ISR2 :
        X12Segment
    {
        Value<string> ShipmentOrOrderStatusCode { get; }

        Value<DateTime> Date { get; }
        
        Value<string> StatusReasonCode { get; }
    }
}