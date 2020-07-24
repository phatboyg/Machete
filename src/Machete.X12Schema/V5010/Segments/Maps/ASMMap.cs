namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ASMMap :
        X12SegmentMap<ASM, X12Entity>
    {
        public ASMMap()
        {
            Id = "ASM";
            Name = "Amount and Settlement Method";
            
            Value(x => x.Amount, 1, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.PaymentMethodCode, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.AmountQualifierCode, 3, x => x.MinLength(1).MaxLength(3));
        }
    }
}