namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class SIMap :
        X12SegmentMap<SI, X12Entity>
    {
        public SIMap()
        {
            Id = "SI";
            Name = "Service Characteristic Identification";
            
            Value(x => x.AgencyQualifierCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ServiceCharacteristicsQualifier1, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.ProductOrServiceId1, 3, x => x.MinLength(1).MaxLength(48).IsRequired());
            Value(x => x.ServiceCharacteristicsQualifier2, 4, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 5, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier3, 6, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId3, 7, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier4, 8, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId4, 9, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier5, 10, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId5, 11, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier6, 12, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId6, 13, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier7, 14, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId7, 15, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier8, 16, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId8, 17, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier9, 18, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId9, 19, x => x.MinLength(1).MaxLength(48));
            Value(x => x.ServiceCharacteristicsQualifier10, 20, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId10, 21, x => x.MinLength(1).MaxLength(48));
        }
    }
}