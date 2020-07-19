// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// GOL (Segment) - Goal Detail
    /// </summary>
    public interface GOL :
        HL7V26Segment
    {
        /// <summary>
        /// GOL-1: Action Code
        /// </summary>
        Value<string> ActionCode { get; }

        /// <summary>
        /// GOL-2: Action Date/Time
        /// </summary>
        Value<DateTimeOffset> ActionDateTime { get; }

        /// <summary>
        /// GOL-3: Goal ID
        /// </summary>
        Value<CWE> GoalId { get; }

        /// <summary>
        /// GOL-4: Goal Instance ID
        /// </summary>
        Value<EI> GoalInstanceId { get; }

        /// <summary>
        /// GOL-5: Episode of Care ID
        /// </summary>
        Value<EI> EpisodeOfCareId { get; }

        /// <summary>
        /// GOL-6: Goal List Priority
        /// </summary>
        Value<decimal> GoalListPriority { get; }

        /// <summary>
        /// GOL-7: Goal Established Date/Time
        /// </summary>
        Value<DateTimeOffset> GoalEstablishedDateTime { get; }

        /// <summary>
        /// GOL-8: Expected Goal Achieve Date/Time
        /// </summary>
        Value<DateTimeOffset> ExpectedGoalAchieveDateTime { get; }

        /// <summary>
        /// GOL-9: Goal Classification
        /// </summary>
        Value<CWE> GoalClassification { get; }

        /// <summary>
        /// GOL-10: Goal Management Discipline
        /// </summary>
        Value<CWE> GoalManagementDiscipline { get; }

        /// <summary>
        /// GOL-11: Current Goal Review Status
        /// </summary>
        Value<CWE> CurrentGoalReviewStatus { get; }

        /// <summary>
        /// GOL-12: Current Goal Review Date/Time
        /// </summary>
        Value<DateTimeOffset> CurrentGoalReviewDateTime { get; }

        /// <summary>
        /// GOL-13: Next Goal Review Date/Time
        /// </summary>
        Value<DateTimeOffset> NextGoalReviewDateTime { get; }

        /// <summary>
        /// GOL-14: Previous Goal Review Date/Time
        /// </summary>
        Value<DateTimeOffset> PreviousGoalReviewDateTime { get; }

        /// <summary>
        /// GOL-15: Goal Review Interval
        /// </summary>
        Value<TQ> GoalReviewInterval { get; }

        /// <summary>
        /// GOL-16: Goal Evaluation
        /// </summary>
        Value<CWE> GoalEvaluation { get; }

        /// <summary>
        /// GOL-17: Goal Evaluation Comment
        /// </summary>
        ValueList<string> GoalEvaluationComment { get; }

        /// <summary>
        /// GOL-18: Goal Life Cycle Status
        /// </summary>
        Value<CWE> GoalLifeCycleStatus { get; }

        /// <summary>
        /// GOL-19: Goal Life Cycle Status Date/Time
        /// </summary>
        Value<DateTimeOffset> GoalLifeCycleStatusDateTime { get; }

        /// <summary>
        /// GOL-20: Goal Target Type
        /// </summary>
        ValueList<CWE> GoalTargetType { get; }

        /// <summary>
        /// GOL-21: Goal Target Name
        /// </summary>
        ValueList<XPN> GoalTargetName { get; }

        /// <summary>
        /// GOL-22: Mood Code
        /// </summary>
        Value<CNE> MoodCode { get; }
    }
}