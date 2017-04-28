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
        HL7ComponentMap<XAD>
    {
        public XADMap()
        {
            Entity(x => x.StreetAddress, 1);
            Value(x => x.OtherDesignation, 2);
            Value(x => x.City, 3);
            Value(x => x.StateOrProvince, 4);
            Value(x => x.ZipOrPostalCode, 5);
            Value(x => x.Country, 6);
            Value(x => x.AddressType, 7);
            Value(x => x.OtherGeographicDesignation, 8);
            Value(x => x.CountyParishCode, 9);
            Value(x => x.CensuTract, 10);
            Value(x => x.AddressRepresentationCode, 11);
            Entity(x => x.AddressValidityRange, 12);
            Value(x => x.EffectiveDate, 13, x => {x.Format = "LONGDATETIME13";});
            Value(x => x.ExpirationDate, 14, x => {x.Format = "LONGDATETIME14";});
            Entity(x => x.ExpirationReason, 15);
            Value(x => x.TemporaryIndicator, 16);
            Value(x => x.BadAddressIndicator, 17);
            Value(x => x.AddressUsage, 18);
            Value(x => x.Addressee, 19);
            Value(x => x.Comment, 20);
            Value(x => x.PreferenceOrder, 21);
            Entity(x => x.ProtectionCode, 22);
            Entity(x => x.AddressIdentifier, 23);
        }
    }
}