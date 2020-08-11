namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BAUMap :
        X12SegmentMap<BAU, X12Entity>
    {
        public BAUMap()
        {
            Id = "BAU";
            Name = "Beginning Segment for the Debit Authorization";
            
            Value(x => x.ReferenceIdentification, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.PaymentMethodCode, 2, x => x.FixedLength(3).IsRequired());
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumberQualifier, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.DepositoryFinancialInstitutionIdentificationNumber, 4, x => x.MinLength(3).MaxLength(12).IsRequired());
            Value(x => x.AccountNumber, 5, x => x.MinLength(1).MaxLength(35).IsRequired());
            Value(x => x.Name, 6, x => x.MinLength(1).MaxLength(60));
        }
    }
}