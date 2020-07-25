namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class GFMap :
        X12SegmentMap<GF, X12Entity>
    {
        public GFMap()
        {
            Id = "GF";
            Name = "Furnished Goods and Services";
            
            Value(x => x.ReferenceIdentificationQualifier1, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification1, 2, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ContractNumber, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.MonetaryAmount, 4, x => x.MinLength(1).MaxLength(18));
            Value(x => x.ReferenceIdentificationQualifier2, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification2, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReleaseNumber, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ReferenceIdentificationQualifier3, 8, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification3, 9, x => x.MinLength(1).MaxLength(30));
        }
    }
}