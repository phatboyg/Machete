// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OM4 (SegmentMap) - Observations that Require Specimens
    /// </summary>
    public class OM4Map :
        HL7V26SegmentMap<OM4>
    {
        public OM4Map()
        {
            Id = "OM4";

            Name = "Observations that Require Specimens";

            Value(x => x.SequenceNumberTestObservationMasterFile, 1);
            Value(x => x.DerivedSpecimen, 2);
            Value(x => x.ContainerDescription, 3);
            Value(x => x.ContainerVolume, 4);
            Entity(x => x.ContainerUnits, 5);
            Entity(x => x.Specimen, 6);
            Entity(x => x.Additive, 7);
            Value(x => x.Preparation, 8);
            Value(x => x.SpecialHandlingRequirements, 9);
            Entity(x => x.NormalCollectionVolume, 10);
            Entity(x => x.MinimumCollectionVolume, 11);
            Value(x => x.SpecimenRequirements, 12);
            Value(x => x.SpecimenPriorities, 13);
            Entity(x => x.SpecimenRetentionTime, 14);
        }
    }
}