namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface B1 :
        X12Segment
    {
        Value<string> StandardCarrierAlphaCode { get; }
        
        Value<string> ShipmentIdentificationNumber { get; }
        
        Value<DateTime> Date { get; }
        
        Value<string> ReservationActionCode { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
        
        Value<string> ShipmentOrWorkAssignmentDeclineReasonCode { get; }
    }
}