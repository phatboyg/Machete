// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SCD (SegmentMap) - Anti-Microbial Cycle Data
    /// </summary>
    public class SCDMap :
        HL7V26SegmentMap<SCD>
    {
        public SCDMap()
        {
            Id = "SCD";

            Name = "Anti-Microbial Cycle Data";

            Value(x => x.CycleStartTime, 1, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.CycleCount, 2);
            Entity(x => x.TempMax, 3);
            Entity(x => x.TempMin, 4);
            Value(x => x.LoadNumber, 5);
            Entity(x => x.ConditionTime, 6);
            Entity(x => x.SterilizeTime, 7);
            Entity(x => x.ExhaustTime, 8);
            Entity(x => x.TotalCycleTime, 9);
            Entity(x => x.DeviceStatus, 10);
            Value(x => x.CycleStartDateTime, 11, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.DryTime, 12);
            Entity(x => x.LeakRate, 13);
            Entity(x => x.ControlTemperature, 14);
            Entity(x => x.SterilizerTemperature, 15);
            Value(x => x.CycleCompleteTime, 16, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.UnderTemperature, 17);
            Entity(x => x.OverTemperature, 18);
            Entity(x => x.AbortCycle, 19);
            Entity(x => x.Alarm, 20);
            Entity(x => x.LongInChargePhase, 21);
            Entity(x => x.LongInExhaustPhase, 22);
            Entity(x => x.LongInFastExhaustPhase, 23);
            Entity(x => x.Reset, 24);
            Entity(x => x.OperatorUnload, 25);
            Entity(x => x.DoorOpen, 26);
            Entity(x => x.ReadingFailure, 27);
            Entity(x => x.CycleType, 28);
            Entity(x => x.rmalRinseTime, 29);
            Entity(x => x.WashTime, 30);
            Entity(x => x.InjectionRate, 31);
            Entity(x => x.ProcedureCode, 32);
            Entity(x => x.PatientIdentifierList, 33);
            Entity(x => x.AttendingDoctor, 34);
            Entity(x => x.DilutionFactor, 35);
            Entity(x => x.FillTime, 36);
            Entity(x => x.InletTemperature, 37);
        }
    }
}