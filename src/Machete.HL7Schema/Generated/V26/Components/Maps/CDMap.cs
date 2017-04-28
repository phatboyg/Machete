// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CD (ComponentMap) - Channel Definition
    /// </summary>
    public class CDMap :
        HL7ComponentMap<CD>
    {
        public CDMap()
        {
            Entity(x => x.ChannelIdentifier, 1);
            Entity(x => x.WaveformSource, 2);
            Entity(x => x.ChannelSensitivityAndUnits, 3);
            Entity(x => x.ChannelCalibrationParameters, 4);
            Value(x => x.ChannelSamplingFrequency, 5);
            Entity(x => x.MinimumAndMaximumDataValues, 6);
        }
    }
}