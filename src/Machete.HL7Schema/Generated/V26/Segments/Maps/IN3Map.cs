// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IN3 (SegmentMap) - Insurance Additional Information, Certification
    /// </summary>
    public class IN3Map :
        HL7SegmentMap<IN3>
    {
        public IN3Map()
        {
            Id = "IN3";

            Name = "Insurance Additional Information, Certification";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Entity(x => x.CertificationNumber, 2);
            Entity(x => x.CertifiedBy, 3);
            Value(x => x.CertificationRequired, 4);
            Entity(x => x.Penalty, 5);
            Value(x => x.CertificationDateTime, 6, x => {x.Format = "LONGDATETIME6";});
            Value(x => x.CertificationModifyDateTime, 7, x => {x.Format = "LONGDATETIME7";});
            Entity(x => x.Operator, 8);
            Value(x => x.CertificationBeginDate, 9, x => {x.Format = "LONGDATE9";});
            Value(x => x.CertificationEndDate, 10, x => {x.Format = "LONGDATE10";});
            Entity(x => x.Days, 11);
            Entity(x => x.NonConcurCodeDescription, 12);
            Value(x => x.NonConcurEffectiveDateTime, 13, x => {x.Format = "LONGDATETIME13";});
            Entity(x => x.PhysicianReviewer, 14);
            Value(x => x.CertificationContact, 15);
            Entity(x => x.CertificationContactPhoneNumber, 16);
            Entity(x => x.AppealReason, 17);
            Entity(x => x.CertificationAgency, 18);
            Entity(x => x.CertificationAgencyPhoneNumber, 19);
            Entity(x => x.PreCertificationRequirement, 20);
            Value(x => x.CaseManager, 21);
            Value(x => x.SecondOpinionDate, 22, x => {x.Format = "LONGDATE22";});
            Value(x => x.SecondOpinionStatus, 23);
            Value(x => x.SecondOpinionDocumentationReceived, 24);
            Entity(x => x.SecondOpinionPhysician, 25);
        }
    }
}