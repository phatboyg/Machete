// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ABS (SegmentMap) - Abstract
    /// </summary>
    public class ABSMap :
        HL7V26SegmentMap<ABS>
    {
        public ABSMap()
        {
            Id = "ABS";

            Name = "Abstract";

            Entity(x => x.DischargeCareProvider, 1);
            Entity(x => x.TransferMedicalServiceCode, 2);
            Entity(x => x.SeverityOfIllnessCode, 3);
            Value(x => x.DateTimeOfAttestation, 4, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.AttestedBy, 5);
            Entity(x => x.TriageCode, 6);
            Value(x => x.AbstractCompletionDateTime, 7, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.AbstractedBy, 8);
            Entity(x => x.CaseCategoryCode, 9);
            Value(x => x.CaesareanSectionIndicator, 10);
            Entity(x => x.GestationCategoryCode, 11);
            Value(x => x.GestationPeriodWeeks, 12);
            Entity(x => x.NewbornCode, 13);
            Value(x => x.StillbornIndicator, 14);
        }
    }
}