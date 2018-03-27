namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class PS1Map :
        X12SegmentMap<PS1, X12Entity>
    {
        public PS1Map()
        {
            Id = "PS1";
            Name = "Purchase Service";
            
            Value(x => x.ReferenceIdentification, 1, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.MonetaryAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
        }
    }
}