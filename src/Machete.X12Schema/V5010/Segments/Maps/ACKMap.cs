namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class ACKMap :
        X12SegmentMap<ACK, X12Entity>
    {
        public ACKMap()
        {
            Id = "ACK";
            Name = "Line Item Acknowledgement";
            
            Value(x => x.LineItemStatusCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisForMeasurementCode, 3, x => x.FixedLength(2));
            Value(x => x.DateOrTimeQualifier, 4, x => x.FixedLength(3));
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.RequestReferenceNumber, 6, x => x.MinLength(1).MaxLength(45));
            Value(x => x.ProductOrServiceIdQualifier1, 7, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 8, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier2, 9, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 10, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier3, 11, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 12, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier4, 13, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId4, 14, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier5, 15, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId5, 16, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier6, 17, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId6, 18, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier7, 19, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId7, 20, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier8, 21, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId8, 22, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier9, 23, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId9, 24, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ProductOrServiceIdQualifier10, 25, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId10, 26, x => x.MinLength(1).MaxLength(48));
            Value(x => x.AgencyQualifierCode, 27, x => x.FixedLength(2));
            Value(x => x.SourceSubqualifier, 28, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IndustryCode, 29, x => x.MinLength(1).MaxLength(30));
        }
    }
}