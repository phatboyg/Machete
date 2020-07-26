namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class PO3Map :
        X12SegmentMap<PO3, X12Entity>
    {
        public PO3Map()
        {
            Id = "PO3";
            Name = "Additional Item Detail";
            
            Value(x => x.ChangeReasonCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Date, 2, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.PriceIdentifierCode, 3, x => x.FixedLength(3));
            Value(x => x.UnitPrice, 4, x => x.MinLength(1).MaxLength(17));
            Value(x => x.BasisOfUnitPriceCode, 5, x => x.MinLength(1).MaxLength(17));
            Value(x => x.Quantity, 6, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOrBasisForMeasurementCode, 7, x => x.FixedLength(2).IsRequired());
            Value(x => x.Description, 8, x => x.MinLength(1).MaxLength(80));
        }
    }
}