// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OM5 (SegmentMap) - Observation Batteries (Sets)
    /// </summary>
    public class OM5Map :
        HL7V26SegmentMap<OM5>
    {
        public OM5Map()
        {
            Id = "OM5";

            Name = "Observation Batteries (Sets)";

            Value(x => x.SequenceNumberTestObservationMasterFile, 1);
            Entity(x => x.TestObservationsIncludedWithinAnOrderedTestBattery, 2);
            Value(x => x.ObservationIdSuffixes, 3);
        }
    }
}