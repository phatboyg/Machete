// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TCC (SegmentMap) - Test Code Configuration
    /// </summary>
    public class TCCMap :
        HL7V26SegmentMap<TCC>
    {
        public TCCMap()
        {
            Id = "TCC";

            Name = "Test Code Configuration";

            Entity(x => x.UniversalServiceIdentifier, 1, x => x.IsRequired());
            Entity(x => x.EquipmentTestApplicationIdentifier, 2, x => x.IsRequired());
            Entity(x => x.SpecimenSource, 3);
            Entity(x => x.AutoDilutionFactorDefault, 4);
            Entity(x => x.RerunDilutionFactorDefault, 5);
            Entity(x => x.PreDilutionFactorDefault, 6);
            Entity(x => x.EndogenouContentOfPreDilutionDiluent, 7);
            Value(x => x.InventoryLimitsWarningLevel, 8);
            Value(x => x.AutomaticRerunAllowed, 9);
            Value(x => x.AutomaticRepeatAllowed, 10);
            Value(x => x.AutomaticReflexAllowed, 11);
            Entity(x => x.EquipmentDynamicRange, 12);
            Entity(x => x.Units, 13);
            Entity(x => x.ProcessingType, 14);
        }
    }
}