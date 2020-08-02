namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G08Map :
        X12SegmentMap<G08, X12Entity>
    {
        public G08Map()
        {
            Id = "G08";
            Name = "Pallet Receipt Disposition";
            
            Value(x => x.QuantityOfPalletsReceived, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.QuantityOfPalletsReturned, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.QuantityContested, 3, x => x.MinLength(1).MaxLength(7));
            Value(x => x.ReceivingConditionCode, 4, x => x.FixedLength(2));
        }
    }
}