namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class PCRMap :
        X12SegmentMap<PCR, X12Entity>
    {
        public PCRMap()
        {
            Id = "PCR";
            Name = "Payment Cancellation Type";
            
            Value(x => x.PaymentCancellationType, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.MonetaryAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
        }
    }
}