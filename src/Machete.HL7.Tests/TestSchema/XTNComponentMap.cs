namespace Machete.HL7.Tests.TestSchema
{
    public class XTNComponentMap :
        HL7ComponentMap<XTNComponent, HL7Component>
    {
        public XTNComponentMap()
        {
            Value(x => x.TelephoneNumber, 0, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
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
            Value(x => x.EffectiveStartDate, 12, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 13, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.ExpirationReason, 14);
            Entity(x => x.ProtectionCode, 15);
            Entity(x => x.SharedTelecommunicationIdentifier, 16);
            Value(x => x.PreferenceOrder, 17);
        }
    }
}