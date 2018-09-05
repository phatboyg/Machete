// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// LCH (Segment) - Location Characteristic
    /// </summary>
    public interface LCH :
        HL7V26Segment
    {
        /// <summary>
        /// LCH-1: Primary Key Value - LCH
        /// </summary>
        Value<PL> PrimaryKeyValue { get; }

        /// <summary>
        /// LCH-2: Segment Action Code
        /// </summary>
        Value<string> SegmentActionCode { get; }

        /// <summary>
        /// LCH-3: Segment Unique Key
        /// </summary>
        Value<EI> SegmentUniqueKey { get; }

        /// <summary>
        /// LCH-4: Location Characteristic ID
        /// </summary>
        Value<CWE> LocationCharacteristicId { get; }

        /// <summary>
        /// LCH-5: Location Characteristic Value - LCH
        /// </summary>
        Value<CWE> LocationCharacteristicValue { get; }
    }
}