namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface PD :
        X12Segment
    {
        Value<string> UnitOfTimePeriodOrInterval { get; }
        
        Value<DateTime> Date { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> Name { get; }
        
        Value<string> Description1 { get; }
        
        Value<string> BreakStructureDetailCode { get; }
        
        Value<string> ReferenceIdentification { get; }
        
        Value<string> Description2 { get; }
        
        Value<string> ProposalDataDetailIdentifierCode { get; }
    }
}