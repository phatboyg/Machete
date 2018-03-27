namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AK5Map :
        X12SegmentMap<AK5, X12Entity>
    {
        public AK5Map()
        {
            Id = "AK4";
            Name = "Data Element Note";

            Value(x => x.TransactionSetAcknowledgementCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.TransactionSetSyntaxErrorCode1, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TransactionSetSyntaxErrorCode2, 3, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TransactionSetSyntaxErrorCode3, 4, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TransactionSetSyntaxErrorCode4, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.TransactionSetSyntaxErrorCode5, 6, x => x.MinLength(1).MaxLength(3));
        }
    }
}