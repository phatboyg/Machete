// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LAN (SegmentMap) - Language Detail
    /// </summary>
    public class LANMap :
        HL7V26SegmentMap<LAN>
    {
        public LANMap()
        {
            Id = "LAN";

            Name = "Language Detail";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Entity(x => x.LanguageCode, 2, x => x.IsRequired());
            Entity(x => x.LanguageAbilityCode, 3);
            Entity(x => x.LanguageProficiencyCode, 4);
        }
    }
}