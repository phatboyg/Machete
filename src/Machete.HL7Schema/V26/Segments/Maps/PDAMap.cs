// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PDA (SegmentMap) - Patient Death and Autopsy
    /// </summary>
    public class PDAMap :
        HL7V26SegmentMap<PDA>
    {
        public PDAMap()
        {
            Id = "PDA";

            Name = "Patient Death and Autopsy";

            Entity(x => x.DeathCauseCode, 1);
            Entity(x => x.DeathLocation, 2);
            Value(x => x.DeathCertifiedIndicator, 3);
            Value(x => x.DeathCertificateSignedDateTime, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.DeathCertifiedBy, 5);
            Value(x => x.AutopsyIndicator, 6);
            Entity(x => x.AutopsyStartAndEndDateTime, 7);
            Entity(x => x.AutopsyPerformedBy, 8);
            Value(x => x.CoronerIndicator, 9);
        }
    }
}