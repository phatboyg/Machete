// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RF1 (SegmentMap) - Referral Information
    /// </summary>
    public class RF1Map :
        HL7V26SegmentMap<RF1>
    {
        public RF1Map()
        {
            Id = "RF1";

            Name = "Referral Information";

            Entity(x => x.ReferralStatus, 1);
            Entity(x => x.ReferralPriority, 2);
            Entity(x => x.ReferralType, 3);
            Entity(x => x.ReferralDisposition, 4);
            Entity(x => x.ReferralCategory, 5);
            Entity(x => x.OriginatingReferralIdentifier, 6, x => x.IsRequired());
            Value(x => x.EffectiveDate, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ExpirationDate, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ProceDate, 9, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ReferralReason, 10);
            Entity(x => x.ExternalReferralIdentifier, 11);
            Entity(x => x.ReferralDocumentationCompletionStatus, 12);
        }
    }
}