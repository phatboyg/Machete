// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CCP (Component) - Channel Calibration Parameters
    /// </summary>
    public interface CCP :
        HL7V26Component
    {
        /// <summary>
        /// CCP-1  Channel Calibration Sensitivity Correction Factor
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ChannelCalibrationSensitivityCorrectionFactor { get; }

        /// <summary>
        /// CCP-2  Channel Calibration Baseline
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ChannelCalibrationBaseline { get; }

        /// <summary>
        /// CCP-3  Channel Calibration Time Skew
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ChannelCalibrationTimeSkew { get; }
    }
}