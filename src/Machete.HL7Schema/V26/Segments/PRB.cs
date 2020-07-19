// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PRB (Segment) - Problem Details
    /// </summary>
    public interface PRB :
        HL7V26Segment
    {
        /// <summary>
        /// PRB-1: Action Code
        /// </summary>
        Value<string> ActionCode { get; }

        /// <summary>
        /// PRB-2: Action Date/Time
        /// </summary>
        Value<DateTimeOffset> ActionDateTime { get; }

        /// <summary>
        /// PRB-3: Problem ID
        /// </summary>
        Value<CWE> ProblemId { get; }

        /// <summary>
        /// PRB-4: Problem Instance ID
        /// </summary>
        Value<EI> ProblemInstanceId { get; }

        /// <summary>
        /// PRB-5: Episode of Care ID
        /// </summary>
        Value<EI> EpisodeOfCareId { get; }

        /// <summary>
        /// PRB-6: Problem List Priority
        /// </summary>
        Value<decimal> ProblemListPriority { get; }

        /// <summary>
        /// PRB-7: Problem Established Date/Time
        /// </summary>
        Value<DateTimeOffset> ProblemEstablishedDateTime { get; }

        /// <summary>
        /// PRB-8: Anticipated Problem Resolution Date/Time
        /// </summary>
        Value<DateTimeOffset> AnticipatedProblemResolutionDateTime { get; }

        /// <summary>
        /// PRB-9: Actual Problem Resolution Date/Time
        /// </summary>
        Value<DateTimeOffset> ActualProblemResolutionDateTime { get; }

        /// <summary>
        /// PRB-10: Problem Classification
        /// </summary>
        Value<CWE> ProblemClassification { get; }

        /// <summary>
        /// PRB-11: Problem Management Discipline
        /// </summary>
        ValueList<CWE> ProblemManagementDiscipline { get; }

        /// <summary>
        /// PRB-12: Problem Persistence
        /// </summary>
        Value<CWE> ProblemPersistence { get; }

        /// <summary>
        /// PRB-13: Problem Confirmation Status
        /// </summary>
        Value<CWE> ProblemConfirmationStatus { get; }

        /// <summary>
        /// PRB-14: Problem Life Cycle Status
        /// </summary>
        Value<CWE> ProblemLifeCycleStatus { get; }

        /// <summary>
        /// PRB-15: Problem Life Cycle Status Date/Time
        /// </summary>
        Value<DateTimeOffset> ProblemLifeCycleStatusDateTime { get; }

        /// <summary>
        /// PRB-16: Problem Date of Onset
        /// </summary>
        Value<DateTimeOffset> ProblemDateOfOnset { get; }

        /// <summary>
        /// PRB-17: Problem Onset Text
        /// </summary>
        Value<string> ProblemOnsetText { get; }

        /// <summary>
        /// PRB-18: Problem Ranking
        /// </summary>
        Value<CWE> ProblemRanking { get; }

        /// <summary>
        /// PRB-19: Certainty of Problem
        /// </summary>
        Value<CWE> CertaintyOfProblem { get; }

        /// <summary>
        /// PRB-20: Probability of Problem (0-1)
        /// </summary>
        Value<decimal> ProbabilityOfProblem { get; }

        /// <summary>
        /// PRB-21: Individual Awareness of Problem
        /// </summary>
        Value<CWE> IndividualAwarenessOfProblem { get; }

        /// <summary>
        /// PRB-22: Problem Prognosis
        /// </summary>
        Value<CWE> ProblemPrognosis { get; }

        /// <summary>
        /// PRB-23: Individual Awareness of Prognosis
        /// </summary>
        Value<CWE> IndividualAwarenessOfPrognosis { get; }

        /// <summary>
        /// PRB-24: Family/Significant Other Awareness of Problem/Prognosis
        /// </summary>
        Value<string> FamilySignificantOtherAwarenessOfProblemPrognosis { get; }

        /// <summary>
        /// PRB-25: Security/Sensitivity
        /// </summary>
        Value<CWE> SecuritySensitivity { get; }

        /// <summary>
        /// PRB-26: Problem Severity
        /// </summary>
        Value<CWE> ProblemSeverity { get; }

        /// <summary>
        /// PRB-27: Problem Perspective
        /// </summary>
        Value<CWE> ProblemPerspective { get; }

        /// <summary>
        /// PRB-28: Mood Code
        /// </summary>
        Value<CNE> MoodCode { get; }
    }
}