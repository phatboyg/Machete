namespace Machete.X12Schema.V5010.Components.Maps
{
    using X12;
    using X12.Configuration;


    public class ReferenceIdentifierMap :
        X12ComponentMap<ReferenceIdentifier, X12Entity>
    {
        public ReferenceIdentifierMap()
        {
            Value(x => x.ReferenceIdentificationQualifier1, 0, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification1, 1, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier2, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification2, 3, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ReferenceIdentificationQualifier3, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification3, 5, x => x.MinLength(1).MaxLength(50));
        }
    }
}