namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class CN1Map : X12SegmentMap<CN1, X12Entity>
    {
        public CN1Map()
        {
            Id = "CN1";
            Name = "Contract Information";
            Value(x => x.ContractTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ContractAmount, 2, x => x.MinLength(1));
            Value(x => x.ContractPercentage, 3, x => x.MinLength(1));
            Value(x => x.ContractCode, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TermsDiscountPercentage, 5, x => x.MinLength(1));
            Value(x => x.ContractVersionIdentifier, 6, x => x.MinLength(1).MaxLength(30));
        }
    }
}