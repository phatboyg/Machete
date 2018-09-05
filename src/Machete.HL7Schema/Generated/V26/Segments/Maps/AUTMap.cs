// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AUT (SegmentMap) - Authorization Information
    /// </summary>
    public class AUTMap :
        HL7V26SegmentMap<AUT>
    {
        public AUTMap()
        {
            Id = "AUT";

            Name = "Authorization Information";

            Entity(x => x.AuthorizingPayorPlanId, 1);
            Entity(x => x.AuthorizingPayorCompanyId, 2, x => {x.Required = true;});
            Value(x => x.AuthorizingPayorCompanyName, 3);
            Value(x => x.AuthorizationEffectiveDate, 4, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.AuthorizationExpirationDate, 5, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.AuthorizationIdentifier, 6);
            Entity(x => x.ReimbursementLimit, 7);
            Value(x => x.RequestedNumberOfTreatments, 8);
            Value(x => x.AuthorizedNumberOfTreatments, 9);
            Value(x => x.ProcessDate, 10, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}