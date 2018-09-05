// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// SCD (Segment) - Anti-Microbial Cycle Data
    /// </summary>
    public interface SCD :
        HL7V26Segment
    {
        /// <summary>
        /// SCD-1: Cycle Start Time
        /// </summary>
        Value<DateTimeOffset> CycleStartTime { get; }

        /// <summary>
        /// SCD-2: Cycle Count
        /// </summary>
        Value<decimal> CycleCount { get; }

        /// <summary>
        /// SCD-3: Temp Max
        /// </summary>
        Value<CQ> TempMax { get; }

        /// <summary>
        /// SCD-4: Temp Min
        /// </summary>
        Value<CQ> TempMin { get; }

        /// <summary>
        /// SCD-5: Load Number
        /// </summary>
        Value<decimal> LoadNumber { get; }

        /// <summary>
        /// SCD-6: Condition Time
        /// </summary>
        Value<CQ> ConditionTime { get; }

        /// <summary>
        /// SCD-7: Sterilize Time
        /// </summary>
        Value<CQ> SterilizeTime { get; }

        /// <summary>
        /// SCD-8: Exhaust Time
        /// </summary>
        Value<CQ> ExhaustTime { get; }

        /// <summary>
        /// SCD-9: Total Cycle Time
        /// </summary>
        Value<CQ> TotalCycleTime { get; }

        /// <summary>
        /// SCD-10: Device Status
        /// </summary>
        Value<CWE> DeviceStatus { get; }

        /// <summary>
        /// SCD-11: Cycle Start Date/Time
        /// </summary>
        Value<DateTimeOffset> CycleStartDateTime { get; }

        /// <summary>
        /// SCD-12: Dry Time
        /// </summary>
        Value<CQ> DryTime { get; }

        /// <summary>
        /// SCD-13: Leak Rate
        /// </summary>
        Value<CQ> LeakRate { get; }

        /// <summary>
        /// SCD-14: Control Temperature
        /// </summary>
        Value<CQ> ControlTemperature { get; }

        /// <summary>
        /// SCD-15: Sterilizer Temperature
        /// </summary>
        Value<CQ> SterilizerTemperature { get; }

        /// <summary>
        /// SCD-16: Cycle Complete Time
        /// </summary>
        Value<DateTimeOffset> CycleCompleteTime { get; }

        /// <summary>
        /// SCD-17: Under Temperature
        /// </summary>
        Value<CQ> UnderTemperature { get; }

        /// <summary>
        /// SCD-18: Over Temperature
        /// </summary>
        Value<CQ> OverTemperature { get; }

        /// <summary>
        /// SCD-19: Abort Cycle
        /// </summary>
        Value<CNE> AbortCycle { get; }

        /// <summary>
        /// SCD-20: Alarm
        /// </summary>
        Value<CNE> Alarm { get; }

        /// <summary>
        /// SCD-21: Long in Charge Phase
        /// </summary>
        Value<CNE> LongInChargePhase { get; }

        /// <summary>
        /// SCD-22: Long in Exhaust Phase
        /// </summary>
        Value<CNE> LongInExhaustPhase { get; }

        /// <summary>
        /// SCD-23: Long in Fast Exhaust Phase
        /// </summary>
        Value<CNE> LongInFastExhaustPhase { get; }

        /// <summary>
        /// SCD-24: Reset
        /// </summary>
        Value<CNE> Reset { get; }

        /// <summary>
        /// SCD-25: Operator - Unload
        /// </summary>
        Value<XCN> OperatorUnload { get; }

        /// <summary>
        /// SCD-26: Door Open
        /// </summary>
        Value<CNE> DoorOpen { get; }

        /// <summary>
        /// SCD-27: Reading Failure
        /// </summary>
        Value<CNE> ReadingFailure { get; }

        /// <summary>
        /// SCD-28: Cycle Type
        /// </summary>
        Value<CWE> CycleType { get; }

        /// <summary>
        /// SCD-29: Thermal Rinse Time
        /// </summary>
        Value<CQ> rmalRinseTime { get; }

        /// <summary>
        /// SCD-30: Wash Time
        /// </summary>
        Value<CQ> WashTime { get; }

        /// <summary>
        /// SCD-31: Injection Rate
        /// </summary>
        Value<CQ> InjectionRate { get; }

        /// <summary>
        /// SCD-32: Procedure Code
        /// </summary>
        Value<CNE> ProcedureCode { get; }

        /// <summary>
        /// SCD-33: Patient Identifier List
        /// </summary>
        ValueList<CX> PatientIdentifierList { get; }

        /// <summary>
        /// SCD-34: Attending Doctor
        /// </summary>
        Value<XCN> AttendingDoctor { get; }

        /// <summary>
        /// SCD-35: Dilution Factor
        /// </summary>
        Value<SN> DilutionFactor { get; }

        /// <summary>
        /// SCD-36: Fill Time
        /// </summary>
        Value<CQ> FillTime { get; }

        /// <summary>
        /// SCD-37: Inlet Temperature
        /// </summary>
        Value<CQ> InletTemperature { get; }
    }
}