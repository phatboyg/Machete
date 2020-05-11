namespace Machete.X12
{
    using System;


    public interface DateTimeRange
    {
        TextSpan StartSpan { get; }
        
        DateTimeOffset StartDate { get; }
        
        TextSpan EndSpan { get; }
        
        DateTimeOffset EndDate { get; }
        
        bool HasStartDate { get; }
        
        bool HasEndDate { get; }
    }
}