// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// XAD (ComponentMap) - Extended Address
    /// </summary>
    public class XADMap :
        HL7V26ComponentMap<XAD>
    {
        public XADMap()
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
            Value(x => x.CensusTract, 9);
            Value(x => x.AddressRepresentationCode, 10);
            Entity(x => x.AddressValidityRange, 11);
            Value(x => x.EffectiveDate, 12, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 13, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
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