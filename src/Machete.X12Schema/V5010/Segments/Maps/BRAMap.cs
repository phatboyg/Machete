namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BRAMap :
        X12SegmentMap<BRA, X12Entity>
    {
        public BRAMap()
        {
            Id = "BRA";
            Name = "Beginning Segment for Receiving Advice or Acceptance Certificate";
            
            Value(x => x.ReferenceIdentification, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TransactionSetPurposeCode, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReceivingAdviceOrAcceptanceCertificationTypeCode, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.Time, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.ReceivingConditionCode, 6, x => x.FixedLength(2));
            Value(x => x.ActionCode, 7, x => x.MinLength(1).MaxLength(2));
        }
    }
}