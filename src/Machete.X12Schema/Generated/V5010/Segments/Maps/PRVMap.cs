namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class PRVMap :
        X12SegmentMap<PRV, X12Entity>
    {
        public PRVMap()
        {
            Id = "PRV";
            Name = "Provider Information";
            
            Value(x => x.ProviderCode, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier, 2, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(50).IsRequired());
        }
    }
}