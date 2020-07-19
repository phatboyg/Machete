// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ODS (SegmentMap) - Dietary Orders, Supplements, and Preferences
    /// </summary>
    public class ODSMap :
        HL7V26SegmentMap<ODS>
    {
        public ODSMap()
        {
            Id = "ODS";

            Name = "Dietary Orders, Supplements, and Preferences";

            Value(x => x.Type, 1, x => x.IsRequired());
            Entity(x => x.ServicePeriod, 2);
            Entity(x => x.DietSupplementOrPreferenceCode, 3, x => x.IsRequired());
            Value(x => x.TextInstruction, 4);
        }
    }
}