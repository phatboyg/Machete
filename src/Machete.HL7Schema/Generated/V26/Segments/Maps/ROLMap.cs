// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ROL (SegmentMap) - Role
    /// </summary>
    public class ROLMap :
        HL7V26SegmentMap<ROL>
    {
        public ROLMap()
        {
            Id = "ROL";

            Name = "Role";

            Entity(x => x.RoleInstanceId, 1);
            Value(x => x.ActionCode, 2, x => {x.Required = true;});
            Entity(x => x.Role, 3, x => {x.Required = true;});
            Entity(x => x.RolePerson, 4, x => {x.Required = true;});
            Value(x => x.RoleBeginDateTime, 5, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.RoleEndDateTime, 6, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.RoleDuration, 7);
            Entity(x => x.RoleActionReason, 8);
            Entity(x => x.ProviderType, 9);
            Entity(x => x.OrganizationUnitType, 10);
            Entity(x => x.OfficeHomeAddressBirthplace, 11);
            Entity(x => x.Phone, 12);
            Entity(x => x.PersonLocation, 13);
        }
    }
}