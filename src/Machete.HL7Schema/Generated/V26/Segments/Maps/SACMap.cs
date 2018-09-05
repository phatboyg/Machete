// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SAC (SegmentMap) - Specimen Container detail
    /// </summary>
    public class SACMap :
        HL7V26SegmentMap<SAC>
    {
        public SACMap()
        {
            Id = "SAC";

            Name = "Specimen Container detail";

            Entity(x => x.ExternalAccessionIdentifier, 1);
            Entity(x => x.AccessionIdentifier, 2);
            Entity(x => x.ContainerIdentifier, 3);
            Entity(x => x.PrimaryParentContainerIdentifier, 4);
            Entity(x => x.EquipmentContainerIdentifier, 5);
            Entity(x => x.SpecimenSource, 6);
            Value(x => x.RegistrationDateTime, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ContainerStatus, 8);
            Entity(x => x.CarrierType, 9);
            Entity(x => x.CarrierIdentifier, 10);
            Value(x => x.PositionInCarrier, 11);
            Entity(x => x.TrayType, 12);
            Entity(x => x.TrayIdentifier, 13);
            Value(x => x.PositionInTray, 14);
            Entity(x => x.Location, 15);
            Value(x => x.ContainerHeight, 16);
            Value(x => x.ContainerDiameter, 17);
            Value(x => x.BarrierDelta, 18);
            Value(x => x.BottomDelta, 19);
            Entity(x => x.ContainerHeightDiameterDeltaUnits, 20);
            Value(x => x.ContainerVolume, 21);
            Value(x => x.AvailableSpecimenVolume, 22);
            Value(x => x.InitialSpecimenVolume, 23);
            Entity(x => x.VolumeUnits, 24);
            Entity(x => x.SeparatorType, 25);
            Entity(x => x.CapType, 26);
            Entity(x => x.Additive, 27);
            Entity(x => x.SpecimenComponent, 28);
            Entity(x => x.DilutionFactor, 29);
            Entity(x => x.Treatment, 30);
            Entity(x => x.Temperature, 31);
            Value(x => x.HemolysiIndex, 32);
            Entity(x => x.HemolysiIndexUnits, 33);
            Value(x => x.LipemiaIndex, 34);
            Entity(x => x.LipemiaIndexUnits, 35);
            Value(x => x.IcteruIndex, 36);
            Entity(x => x.IcteruIndexUnits, 37);
            Value(x => x.FibrinIndex, 38);
            Entity(x => x.FibrinIndexUnits, 39);
            Entity(x => x.SystemInducedContaminants, 40);
            Entity(x => x.DrugInterference, 41);
            Entity(x => x.ArtificialBlood, 42);
            Entity(x => x.SpecialHandlingCode, 43);
            Entity(x => x.OtherEnvironmentalFactors, 44);
        }
    }
}