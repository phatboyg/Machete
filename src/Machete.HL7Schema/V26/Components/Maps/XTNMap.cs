// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// XTN (ComponentMap) - Extended Telecommunication Number
    /// </summary>
    public class XTNMap :
        HL7V26ComponentMap<XTN>
    {
        public XTNMap()
        {
            Value(x => x.TelephoneNumber, 0);
            Value(x => x.TelecommunicationUseCode, 1);
            Value(x => x.TelecommunicationEquipmentType, 2);
            Value(x => x.CommunicationAddress, 3);
            Value(x => x.CountryCode, 4);
            Value(x => x.AreaCityCode, 5);
            Value(x => x.LocalNumber, 6);
            Value(x => x.Extension, 7);
            Value(x => x.AnyText, 8);
            Value(x => x.ExtensionPrefix, 9);
            Value(x => x.SpeedDialCode, 10);
            Value(x => x.UnformattedTelephoneNumber, 11);
            Value(x => x.EffectiveStartDate, 12, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ExpirationDate, 13, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ExpirationReason, 14);
            Entity(x => x.ProtectionCode, 15);
            Entity(x => x.SharedTelecommunicationIdentifier, 16);
            Value(x => x.PreferenceOrder, 17);
        }
    }
}