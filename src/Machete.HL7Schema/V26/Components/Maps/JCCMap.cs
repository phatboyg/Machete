// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// JCC (ComponentMap) - Job Code/Class
    /// </summary>
    public class JCCMap :
        HL7V26ComponentMap<JCC>
    {
        public JCCMap()
        {
            Value(x => x.JobCode, 0);
            Value(x => x.JobClass, 1);
            Value(x => x.JobDescriptionText, 2);
        }
    }
}