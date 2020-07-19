namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class TXIMap :
        X12SegmentMap<TXI, X12Entity>
    {
        public TXIMap()
        {
            Id = "TXI";
            Name = "Tax Information";
            
            Value(x => x.TaxTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.PercentageAsDecimal, 2, x => x.MinLength(1).MaxLength(18));
            Value(x => x.MonetaryAmount, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.TaxJurisdictionCodeQualifier, 4, x => x.FixedLength(2));
            Value(x => x.TaxJurisdictionCode, 5, x => x.MinLength(1).MaxLength(10));
            Value(x => x.TaxExemptCode, 6, x => x.FixedLength(1));
            Value(x => x.RelationshipCode, 7, x => x.FixedLength(1));
            Value(x => x.DollarBasisForPercent, 8, x => x.MinLength(1).MaxLength(9));
            Value(x => x.TaxIdentificationNumber, 9, x => x.MinLength(1).MaxLength(20));
            Value(x => x.AssignedIdentification, 10, x => x.MinLength(1).MaxLength(20));
        }
    }
}