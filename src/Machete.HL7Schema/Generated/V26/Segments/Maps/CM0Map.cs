// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CM0 (SegmentMap) - Clinical Study Master
    /// </summary>
    public class CM0Map :
        HL7SegmentMap<CM0>
    {
        public CM0Map()
        {
            Id = "CM0";

            Name = "Clinical Study Master";

            Value(x => x.SetId, 1);
            Entity(x => x.SponsorStudyId, 2, x => {x.Required = true;});
            Entity(x => x.AlternateStudyId, 3);
            Value(x => x.TitleOfStudy, 4, x => {x.Required = true;});
            Entity(x => x.ChairmanOfStudy, 5);
            Value(x => x.LastIRBApprovalDate, 6, x => {x.Format = "LONGDATE6";});
            Value(x => x.TotalAccrualToDate, 7);
            Value(x => x.LastAccrualDate, 8, x => {x.Format = "LONGDATE8";});
            Entity(x => x.ContactForStudy, 9);
            Entity(x => x.ContactSTelephoneNumber, 10);
            Entity(x => x.ContactSAddress, 11);
        }
    }
}