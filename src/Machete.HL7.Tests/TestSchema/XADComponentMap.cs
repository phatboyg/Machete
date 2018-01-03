namespace Machete.HL7.Tests.TestSchema
{
    public class XADComponentMap :
        HL7ComponentMap<XADComponent, HL7Component>
    {
        public XADComponentMap()
        {
            Entity(x => x.StreetAddress, 0);
            Value(x => x.OtherDesignation, 1);
            Value(x => x.City, 2);
            Value(x => x.StateOrProvince, 3);
            Value(x => x.ZipOrPostalCode, 4);
            Value(x => x.Country, 5);
            Value(x => x.AddressType, 6);
            Value(x => x.OtherGeographicDesignation, 7);
            Value(x => x.CountyParishCode, 8);
            Value(x => x.CensuTract, 9);
            Value(x => x.AddressRepresentationCode, 10);
            Entity(x => x.AddressValidityRange, 11);
            Value(x => x.EffectiveDate, 12, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 13, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.ExpirationReason, 14);
            Value(x => x.TemporaryIndicator, 15);
            Value(x => x.BadAddressIndicator, 16);
            Value(x => x.AddressUsage, 17);
            Value(x => x.Addressee, 18);
            Value(x => x.Comment, 19);
            Value(x => x.PreferenceOrder, 20);
            Entity(x => x.ProtectionCode, 21);
            Entity(x => x.AddressIdentifier, 22);
        }
    }
}