// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRB (SegmentMap) - Problem Details
    /// </summary>
    public class PRBMap :
        HL7V26SegmentMap<PRB>
    {
        public PRBMap()
        {
            Id = "PRB";

            Name = "Problem Details";

            Value(x => x.ActionCode, 1, x => x.IsRequired());
            Value(x => x.ActionDateTime, 2, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.Required = true;
            });
            Entity(x => x.ProblemId, 3, x => x.IsRequired());
            Entity(x => x.ProblemInstanceId, 4, x => x.IsRequired());
            Entity(x => x.EpisodeOfCareId, 5);
            Value(x => x.ProblemListPriority, 6);
            Value(x => x.ProblemEstablishedDateTime, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.AnticipatedProblemResolutionDateTime, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ActualProblemResolutionDateTime, 9, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ProblemClassification, 10);
            Entity(x => x.ProblemManagementDiscipline, 11);
            Entity(x => x.ProblemPersistence, 12);
            Entity(x => x.ProblemConfirmationStatus, 13);
            Entity(x => x.ProblemLifeCycleStatus, 14);
            Value(x => x.ProblemLifeCycleStatusDateTime, 15, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ProblemDateOfOnset, 16, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ProblemOnsetText, 17);
            Entity(x => x.ProblemRanking, 18);
            Entity(x => x.CertaintyOfProblem, 19);
            Value(x => x.ProbabilityOfProblem, 20);
            Entity(x => x.IndividualAwarenessOfProblem, 21);
            Entity(x => x.ProblemPrognosis, 22);
            Entity(x => x.IndividualAwarenessOfPrognosis, 23);
            Value(x => x.FamilySignificantOtherAwarenessOfProblemPrognosis, 24);
            Entity(x => x.SecuritySensitivity, 25);
            Entity(x => x.ProblemSeverity, 26);
            Entity(x => x.ProblemPerspective, 27);
            Entity(x => x.MoodCode, 28);
        }
    }
}