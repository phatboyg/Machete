// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// GOL (SegmentMap) - Goal Detail
    /// </summary>
    public class GOLMap :
        HL7V26SegmentMap<GOL>
    {
        public GOLMap()
        {
            Id = "GOL";

            Name = "Goal Detail";

            Value(x => x.ActionCode, 1, x => {x.Required = true;});
            Value(x => x.ActionDateTime, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;x.Required = true;});
            Entity(x => x.GoalId, 3, x => {x.Required = true;});
            Entity(x => x.GoalInstanceId, 4, x => {x.Required = true;});
            Entity(x => x.EpisodeOfCareId, 5);
            Value(x => x.GoalListPriority, 6);
            Value(x => x.GoalEstablishedDateTime, 7, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpectedGoalAchieveDateTime, 8, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.GoalClassification, 9);
            Entity(x => x.GoalManagementDiscipline, 10);
            Entity(x => x.CurrentGoalReviewStatus, 11);
            Value(x => x.CurrentGoalReviewDateTime, 12, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.NextGoalReviewDateTime, 13, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.PreviousGoalReviewDateTime, 14, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.GoalReviewInterval, 15);
            Entity(x => x.GoalEvaluation, 16);
            Value(x => x.GoalEvaluationComment, 17);
            Entity(x => x.GoalLifeCycleStatus, 18);
            Value(x => x.GoalLifeCycleStatusDateTime, 19, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.GoalTargetType, 20);
            Entity(x => x.GoalTargetName, 21);
            Entity(x => x.MoodCode, 22);
        }
    }
}