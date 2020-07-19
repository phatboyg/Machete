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
        HL7V26ComponentMap<CD>
    {
        public CDMap()
        {
            Entity(x => x.ChannelIdentifier, 0);
            Entity(x => x.WaveformSource, 1);
            Entity(x => x.ChannelSensitivityAndUnits, 2);
            Entity(x => x.ChannelCalibrationParameters, 3);
            Value(x => x.ChannelSamplingFrequency, 4);
            Entity(x => x.MinimumAndMaximumDataValues, 5);
        }
    }
}