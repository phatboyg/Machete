namespace Machete.X12Schema.V5010.Segments
{
    using System;
    using Components;
    using X12;


    public interface PAM :
        X12Segment
    {
        Value<string> QuantityQualifier { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }
        
        Value<string> AmountQualifierCode { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<string> UnitOfTimePeriodOrInterval { get; }
        
        Value<string> DateTimeQualifier1 { get; }
        
        Value<DateTime> Date1 { get; }
        
        Value<TimeSpan> Time1 { get; }
        
        Value<string> DateTimeQualifier2 { get; }
        
        Value<DateTime> Date2 { get; }
        
        Value<TimeSpan> Time2 { get; }
        
        Value<string> PercentQualifier { get; }
        
        Value<string> PercentageAsDecimal { get; }
        
        Value<string> YesNoConditionOrResponseCode { get; }
    }
}