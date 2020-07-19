namespace Machete.X12Schema.V5010.Segments
{
    using Components;
    using X12;


    public interface SLN :
        X12Segment
    {
        Value<string> AssignedIdentification1 { get; }
        
        Value<string> AssignedIdentification2 { get; }
        
        Value<string> RelationshipCode1 { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<C001> CompositeUnitOfMeasure { get; }
        
        Value<string> UnitPrice { get; }
        
        Value<string> BasisOfUnitPriceCode { get; }
        
        Value<string> RelationshipCode2 { get; }
        
        Value<string> ProductOrServiceIdQualifier1 { get; }
        
        Value<string> ProductOrServiceId1 { get; }
        
        Value<string> ProductOrServiceIdQualifier2 { get; }
        
        Value<string> ProductOrServiceId2 { get; }
        
        Value<string> ProductOrServiceIdQualifier3 { get; }
        
        Value<string> ProductOrServiceId3 { get; }
        
        Value<string> ProductOrServiceIdQualifier4 { get; }
        
        Value<string> ProductOrServiceId4 { get; }
        
        Value<string> ProductOrServiceIdQualifier5 { get; }
        
        Value<string> ProductOrServiceId5 { get; }
        
        Value<string> ProductOrServiceIdQualifier6 { get; }
        
        Value<string> ProductOrServiceId6 { get; }
        
        Value<string> ProductOrServiceIdQualifier7 { get; }
        
        Value<string> ProductOrServiceId7 { get; }
        
        Value<string> ProductOrServiceIdQualifier8 { get; }
        
        Value<string> ProductOrServiceId8 { get; }
        
        Value<string> ProductOrServiceIdQualifier9 { get; }
        
        Value<string> ProductOrServiceId9 { get; }
        
        Value<string> ProductOrServiceIdQualifier10 { get; }
        
        Value<string> ProductOrServiceId10 { get; }
    }
}