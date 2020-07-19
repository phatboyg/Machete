// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CCP (ComponentMap) - Channel Calibration Parameters
    /// </summary>
    public class CCPMap :
        HL7V26ComponentMap<CCP>
    {
        public CCPMap()
        {
            Value(x => x.ChannelCalibrationSensitivityCorrectionFactor, 0);
            Value(x => x.ChannelCalibrationBaseline, 1);
            Value(x => x.ChannelCalibrationTimeSkew, 2);
        }
    }
}