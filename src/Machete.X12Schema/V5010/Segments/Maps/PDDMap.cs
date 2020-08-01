namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PDDMap :
        X12SegmentMap<PDD, X12Entity>
    {
        public PDDMap()
        {
            Id = "PDD";
            Name = "Pricing Data Detail";
            
            Value(x => x.AssignedIdentification, 1, x => x.MinLength(1).MaxLength(20).IsRequired());
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.MonetaryAmount, 3, x => x.MinLength(1).MaxLength(18));
            Value(x => x.PercentageAsDecimal, 4, x => x.MinLength(1).MaxLength(10));
            Value(x => x.ProposalDataDetailIdentifierCode, 5, x => x.MinLength(1).MaxLength(3));
        }
    }
}