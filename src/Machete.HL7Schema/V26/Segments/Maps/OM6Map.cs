// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OM6 (SegmentMap) - Observations that are Calculated from Other Observations
    /// </summary>
    public class OM6Map :
        HL7V26SegmentMap<OM6>
    {
        public OM6Map()
        {
            Id = "OM6";

            Name = "Observations that are Calculated from Other Observations";

            Value(x => x.SequenceNumberTestObservationMasterFile, 1);
            Value(x => x.DerivationRule, 2);
        }
    }
}