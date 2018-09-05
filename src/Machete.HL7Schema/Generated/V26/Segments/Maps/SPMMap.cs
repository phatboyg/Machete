// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SPM (SegmentMap) - Specimen
    /// </summary>
    public class SPMMap :
        HL7V26SegmentMap<SPM>
    {
        public SPMMap()
        {
            Id = "SPM";

            Name = "Specimen";

            Value(x => x.SetId, 1);
            Entity(x => x.SpecimenId, 2);
            Entity(x => x.SpecimenParentIds, 3);
            Entity(x => x.SpecimenType, 4, x => x.IsRequired());
            Entity(x => x.SpecimenTypeModifier, 5);
            Entity(x => x.SpecimenAdditives, 6);
            Entity(x => x.SpecimenCollectionMethod, 7);
            Entity(x => x.SpecimenSourceSite, 8);
            Entity(x => x.SpecimenSourceSiteModifier, 9);
            Entity(x => x.SpecimenCollectionSite, 10);
            Entity(x => x.SpecimenRole, 11);
            Entity(x => x.SpecimenCollectionAmount, 12);
            Value(x => x.GroupedSpecimenCount, 13);
            Value(x => x.SpecimenDescription, 14);
            Entity(x => x.SpecimenHandlingCode, 15);
            Entity(x => x.SpecimenRiskCode, 16);
            Entity(x => x.SpecimenCollectionDateTime, 17);
            Value(x => x.SpecimenReceivedDateTime, 18, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.SpecimenExpirationDateTime, 19, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.SpecimenAvailability, 20);
            Entity(x => x.SpecimenRejectReason, 21);
            Entity(x => x.SpecimenQuality, 22);
            Entity(x => x.SpecimenAppropriateness, 23);
            Entity(x => x.SpecimenCondition, 24);
            Entity(x => x.SpecimenCurrentQuantity, 25);
            Value(x => x.NumberOfSpecimenContainers, 26);
            Entity(x => x.ContainerType, 27);
            Entity(x => x.ContainerCondition, 28);
            Entity(x => x.SpecimenChildRole, 29);
        }
    }
}