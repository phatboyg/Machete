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
        HL7ComponentMap<XTN>
    {
        public XTNMap()
        {
            Value(x => x.TelephoneNumber, 1, x => {x.Format = "LONGDATETIME1";});
            Value(x => x.TelecommunicationUseCode, 2);
            Value(x => x.TelecommunicationEquipmentType, 3);
            Value(x => x.CommunicationAddress, 4);
            Value(x => x.CountryCode, 5);
            Value(x => x.AreaCityCode, 6);
            Value(x => x.LocalNumber, 7);
            Value(x => x.Extension, 8);
            Value(x => x.AnyText, 9);
            Value(x => x.ExtensionPrefix, 10);
            Value(x => x.SpeedDialCode, 11);
            Value(x => x.UnformattedTelephoneNumber, 12);
            Value(x => x.EffectiveStartDate, 13, x => {x.Format = "LONGDATETIME13";});
            Value(x => x.ExpirationDate, 14, x => {x.Format = "LONGDATETIME14";});
            Entity(x => x.ExpirationReason, 15);
            Entity(x => x.ProtectionCode, 16);
            Entity(x => x.SharedTelecommunicationIdentifier, 17);
            Value(x => x.PreferenceOrder, 18);
        }
    }
}