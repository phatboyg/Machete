// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OM3 (SegmentMap) - Categorical Service/Test/Observation
    /// </summary>
    public class OM3Map :
        HL7SegmentMap<OM3>
    {
        public OM3Map()
        {
            Id = "OM3";

            Name = "Categorical Service/Test/Observation";

            Value(x => x.SequenceNumberTestObservationMasterFile, 1);
            Entity(x => x.PreferredCodingSystem, 2);
            Entity(x => x.ValidCodedAnswers, 3);
            Entity(x => x.NormalTextCodesForCategoricalObservations, 4);
            Entity(x => x.AbnormalTextCodesForCategoricalObservations, 5);
            Entity(x => x.CriticalTextCodesForCategoricalObservations, 6);
            Value(x => x.ValueType, 7);
        }
    }
}