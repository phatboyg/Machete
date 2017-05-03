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
            Entity(x => x.Privilege, 0);
            Entity(x => x.PrivilegeClass, 1);
            Value(x => x.ExpirationDate, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ActivationDate, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.Facility, 4);
        }
    }
}