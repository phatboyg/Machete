// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// URS (SegmentMap) - Unsolicited Selection
    /// </summary>
    public class URSMap :
        HL7V26SegmentMap<URS>
    {
        public URSMap()
        {
            Id = "URS";

            Name = "Unsolicited Selection";

            Value(x => x.RUWhereSubjectDefinition, 1, x => x.IsRequired());
            Value(x => x.RUWhenDataStartDateTime, 2, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.RUWhenDataEndDateTime, 3, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.RUWhatUserQualifier, 4);
            Value(x => x.RUOtherResultsSubjectDefinition, 5);
            Value(x => x.RUWhichDateTimeQualifier, 6);
            Value(x => x.RUWhichDateTimeStatusQualifier, 7);
            Value(x => x.RUDateTimeSelectionQualifier, 8);
            Entity(x => x.RUQuantityTimingQualifier, 9);
        }
    }
}