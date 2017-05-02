// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PT (ComponentMap) - Processing Type
    /// </summary>
    public class PTMap :
        HL7ComponentMap<PT>
    {
        public PTMap()
        {
            Value(x => x.ProcessingId, 0);
            Value(x => x.ProcessingMode, 1);
        }
    }
}