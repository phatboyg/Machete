namespace Machete.X12Schema.V5010.Components.Maps
{
    using X12;
    using X12.Configuration;


    public class ProcedureIdentifierMap :
        X12ComponentMap<ProcedureIdentifier, X12Entity>
    {
        public ProcedureIdentifierMap()
        {
            Value(x => x.ProductIdentifierQualifier, 0, x => x.FixedLength(2).IsRequired());
            Value(x => x.ProcedureCode, 1, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.ProcedureModifier1, 2, x => x.FixedLength(2));
            Value(x => x.ProcedureModifier2, 3, x => x.FixedLength(2));
            Value(x => x.ProcedureModifier3, 4, x => x.FixedLength(2));
            Value(x => x.ProcedureModifier4, 5, x => x.FixedLength(2));
            Value(x => x.Description, 6, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ProductIdentifier, 7, x => x.MinLength(1).MaxLength(48));
        }
    }
}