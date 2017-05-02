// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// WVS (ComponentMap) - Waveform Source
    /// </summary>
    public class WVSMap :
        HL7ComponentMap<WVS>
    {
        public WVSMap()
        {
            Value(x => x.SourceOneName, 0);
            Value(x => x.SourceTwoName, 1);
        }
    }
}