namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BSNMap :
        X12SegmentMap<BSN, X12Entity>
    {
        public BSNMap()
        {
            Id = "BSN";
            Name = "Beginning Segment for Ship Notice";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ShipmentIdentification, 2, x => x.MinLength(2).MaxLength(30).IsRequired());
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 4, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.HierarchicalStructureCode, 5, x => x.FixedLength(4));
            Value(x => x.TransactionTypeCode, 6, x => x.FixedLength(2));
            Value(x => x.StatusReasonCode, 7, x => x.FixedLength(3));
        }
    }
}