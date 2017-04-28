// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PIP (ComponentMap) - Practitioner Institutional Privileges
    /// </summary>
    public class PIPMap :
        HL7ComponentMap<PIP>
    {
        public PIPMap()
        {
            Entity(x => x.Privilege, 1);
            Entity(x => x.PrivilegeClass, 2);
            Value(x => x.ExpirationDate, 3, x => {x.Format = "LONGDATETIME3";});
            Value(x => x.ActivationDate, 4, x => {x.Format = "LONGDATETIME4";});
            Entity(x => x.Facility, 5);
        }
    }
}