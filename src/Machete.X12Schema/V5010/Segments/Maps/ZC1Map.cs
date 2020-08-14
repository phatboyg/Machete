namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class ZC1Map :
        X12SegmentMap<ZC1, X12Entity>
    {
        public ZC1Map()
        {
            Id = "ZC1";
            Name = "Beginning Segment for Data Correction of Change";

            Value(x => x.ShipmentIdentificationNumber, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.EquipmentInitial, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.TransactionReferenceNumber, 4, x => x.MinLength(1).MaxLength(50));
            Value(x => x.TransactionReferenceDate, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.CorrectionIndicator, 6, x => x.FixedLength(2));
            Value(x => x.StandardCarrierAlphaCode, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.TransportationMethodCode, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.EquipmentNumberCheckDigit, 9, x => x.FixedLength(1));
        }
    }
}