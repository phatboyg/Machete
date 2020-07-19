// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// SAC (Segment) - Specimen Container detail
    /// </summary>
    public interface SAC :
        HL7V26Segment
    {
        /// <summary>
        /// SAC-1: External Accession Identifier
        /// </summary>
        Value<EI> ExternalAccessionIdentifier { get; }

        /// <summary>
        /// SAC-2: Accession Identifier
        /// </summary>
        Value<EI> AccessionIdentifier { get; }

        /// <summary>
        /// SAC-3: Container Identifier
        /// </summary>
        Value<EI> ContainerIdentifier { get; }

        /// <summary>
        /// SAC-4: Primary (Parent) Container Identifier
        /// </summary>
        Value<EI> PrimaryParentContainerIdentifier { get; }

        /// <summary>
        /// SAC-5: Equipment Container Identifier
        /// </summary>
        Value<EI> EquipmentContainerIdentifier { get; }

        /// <summary>
        /// SAC-6: Specimen Source
        /// </summary>
        Value<SPS> SpecimenSource { get; }

        /// <summary>
        /// SAC-7: Registration Date/Time
        /// </summary>
        Value<DateTimeOffset> RegistrationDateTime { get; }

        /// <summary>
        /// SAC-8: Container Status
        /// </summary>
        Value<CWE> ContainerStatus { get; }

        /// <summary>
        /// SAC-9: Carrier Type
        /// </summary>
        Value<CWE> CarrierType { get; }

        /// <summary>
        /// SAC-10: Carrier Identifier
        /// </summary>
        Value<EI> CarrierIdentifier { get; }

        /// <summary>
        /// SAC-11: Position in Carrier
        /// </summary>
        ValueList<decimal> PositionInCarrier { get; }

        /// <summary>
        /// SAC-12: Tray Type - SAC
        /// </summary>
        Value<CWE> TrayType { get; }

        /// <summary>
        /// SAC-13: Tray Identifier
        /// </summary>
        Value<EI> TrayIdentifier { get; }

        /// <summary>
        /// SAC-14: Position in Tray
        /// </summary>
        ValueList<decimal> PositionInTray { get; }

        /// <summary>
        /// SAC-15: Location
        /// </summary>
        ValueList<CWE> Location { get; }

        /// <summary>
        /// SAC-16: Container Height
        /// </summary>
        Value<decimal> ContainerHeight { get; }

        /// <summary>
        /// SAC-17: Container Diameter
        /// </summary>
        Value<decimal> ContainerDiameter { get; }

        /// <summary>
        /// SAC-18: Barrier Delta
        /// </summary>
        Value<decimal> BarrierDelta { get; }

        /// <summary>
        /// SAC-19: Bottom Delta
        /// </summary>
        Value<decimal> BottomDelta { get; }

        /// <summary>
        /// SAC-20: Container Height/Diameter/Delta Units
        /// </summary>
        Value<CWE> ContainerHeightDiameterDeltaUnits { get; }

        /// <summary>
        /// SAC-21: Container Volume
        /// </summary>
        Value<decimal> ContainerVolume { get; }

        /// <summary>
        /// SAC-22: Available Specimen Volume
        /// </summary>
        Value<decimal> AvailableSpecimenVolume { get; }

        /// <summary>
        /// SAC-23: Initial Specimen Volume
        /// </summary>
        Value<decimal> InitialSpecimenVolume { get; }

        /// <summary>
        /// SAC-24: Volume Units
        /// </summary>
        Value<CWE> VolumeUnits { get; }

        /// <summary>
        /// SAC-25: Separator Type
        /// </summary>
        Value<CWE> SeparatorType { get; }

        /// <summary>
        /// SAC-26: Cap Type
        /// </summary>
        Value<CWE> CapType { get; }

        /// <summary>
        /// SAC-27: Additive
        /// </summary>
        ValueList<CWE> Additive { get; }

        /// <summary>
        /// SAC-28: Specimen Component
        /// </summary>
        Value<CWE> SpecimenComponent { get; }

        /// <summary>
        /// SAC-29: Dilution Factor
        /// </summary>
        Value<SN> DilutionFactor { get; }

        /// <summary>
        /// SAC-30: Treatment
        /// </summary>
        Value<CWE> Treatment { get; }

        /// <summary>
        /// SAC-31: Temperature
        /// </summary>
        Value<SN> Temperature { get; }

        /// <summary>
        /// SAC-32: Hemolysis Index
        /// </summary>
        Value<decimal> HemolysiIndex { get; }

        /// <summary>
        /// SAC-33: Hemolysis Index Units
        /// </summary>
        Value<CWE> HemolysiIndexUnits { get; }

        /// <summary>
        /// SAC-34: Lipemia Index
        /// </summary>
        Value<decimal> LipemiaIndex { get; }

        /// <summary>
        /// SAC-35: Lipemia Index Units
        /// </summary>
        Value<CWE> LipemiaIndexUnits { get; }

        /// <summary>
        /// SAC-36: Icterus Index
        /// </summary>
        Value<decimal> IcteruIndex { get; }

        /// <summary>
        /// SAC-37: Icterus Index Units
        /// </summary>
        Value<CWE> IcteruIndexUnits { get; }

        /// <summary>
        /// SAC-38: Fibrin Index
        /// </summary>
        Value<decimal> FibrinIndex { get; }

        /// <summary>
        /// SAC-39: Fibrin Index Units
        /// </summary>
        Value<CWE> FibrinIndexUnits { get; }

        /// <summary>
        /// SAC-40: System Induced Contaminants
        /// </summary>
        ValueList<CWE> SystemInducedContaminants { get; }

        /// <summary>
        /// SAC-41: Drug Interference
        /// </summary>
        ValueList<CWE> DrugInterference { get; }

        /// <summary>
        /// SAC-42: Artificial Blood
        /// </summary>
        Value<CWE> ArtificialBlood { get; }

        /// <summary>
        /// SAC-43: Special Handling Code
        /// </summary>
        ValueList<CWE> SpecialHandlingCode { get; }

        /// <summary>
        /// SAC-44: Other Environmental Factors
        /// </summary>
        ValueList<CWE> OtherEnvironmentalFactors { get; }
    }
}