// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CD (Component) - Channel Definition
    /// </summary>
    public interface CD :
        HL7V26Component
    {
        /// <summary>
        /// CD-1  Channel Identifier
        /// </summary>
        /// <returns>The WVI value</returns>
        Value<WVI> ChannelIdentifier { get; }

        /// <summary>
        /// CD-2  Waveform Source
        /// </summary>
        /// <returns>The WVS value</returns>
        Value<WVS> WaveformSource { get; }

        /// <summary>
        /// CD-3  Channel Sensitivity and Units
        /// </summary>
        /// <returns>The CSU value</returns>
        Value<CSU> ChannelSensitivityAndUnits { get; }

        /// <summary>
        /// CD-4  Channel Calibration Parameters
        /// </summary>
        /// <returns>The CCP value</returns>
        Value<CCP> ChannelCalibrationParameters { get; }

        /// <summary>
        /// CD-5  Channel Sampling Frequency
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ChannelSamplingFrequency { get; }

        /// <summary>
        /// CD-6  Minimum and Maximum Data Values
        /// </summary>
        /// <returns>The NR value</returns>
        Value<NR> MinimumAndMaximumDataValues { get; }
    }
}