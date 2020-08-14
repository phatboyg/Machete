namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface X2 :
        X12Segment
    {
        Value<string> ImportLicenseNumber1 { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<string> ImportLicenseNumber2 { get; }
        
        Value<DateTime> Date3 { get; }
        
        Value<DateTime> Date4 { get; }
    }
}