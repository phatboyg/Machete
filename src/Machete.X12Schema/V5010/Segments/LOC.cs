namespace Machete.X12Schema.V5010
{
    using Components;
    using X12;


    public interface LOC :
        X12Segment
    {
        Value<string> ReferenceIdentificationQualifier1 { get; }

        Value<string> ReferenceIdentification1 { get; }
        
        Value<string> Description1 { get; }

        Value<string> ReferenceIdentification2 { get; }
        
        Value<string> Category { get; }
        
        Value<string> ReferenceIdentificationQualifier2 { get; }

        Value<string> ReferenceIdentification3 { get; }
        
        Value<string> Description2 { get; }
        
        Value<string> ReferenceIdentification4 { get; }
        
        Value<decimal> MeasurementValue1 { get; }
        
        Value<C001> CompositeUnitOfMeasure1 { get; }
        
        Value<decimal> MeasurementValue2 { get; }
        
        Value<C001> CompositeUnitOfMeasure2 { get; }
        
        Value<decimal> MeasurementValue3 { get; }
        
        Value<C001> CompositeUnitOfMeasure3 { get; }
        
        Value<decimal> MeasurementValue4 { get; }
        
        Value<C001> CompositeUnitOfMeasure4 { get; }
        
        Value<decimal> MeasurementValue5 { get; }
        
        Value<C001> CompositeUnitOfMeasure5 { get; }
        
        Value<decimal> MeasurementValue6 { get; }
        
        Value<C001> CompositeUnitOfMeasure6 { get; }
        
        Value<string> ReferenceIdentificationQualifier3 { get; }

        Value<string> ReferenceIdentification5 { get; }
        
        Value<string> Description3 { get; }
    }
}