namespace Machete.X12Schema.V5010
{
    using X12;


    public interface ProcedureIdentifier :
        X12Component
    {
        Value<string> ProductIdentifierQualifier { get; }

        Value<string> ProcedureCode { get; }
        
        Value<string> ProcedureModifier1 { get; }
        
        Value<string> ProcedureModifier2 { get; }
        
        Value<string> ProcedureModifier3 { get; }
        
        Value<string> ProcedureModifier4 { get; }
        
        Value<string> Description { get; }
        
        Value<string> ProductIdentifier { get; }
    }
}