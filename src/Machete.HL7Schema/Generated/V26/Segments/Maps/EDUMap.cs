// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EDU (SegmentMap) - Educational Detail
    /// </summary>
    public class EDUMap :
        HL7V26SegmentMap<EDU>
    {
        public EDUMap()
        {
            Id = "EDU";

            Name = "Educational Detail";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.AcademicDegree, 2);
            Entity(x => x.AcademicDegreeProgramDateRange, 3);
            Entity(x => x.AcademicDegreeProgramParticipationDateRange, 4);
            Value(x => x.AcademicDegreeGrantedDate, 5, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.School, 6);
            Entity(x => x.SchoolTypeCode, 7);
            Entity(x => x.SchoolAddress, 8);
            Entity(x => x.MajorFieldOfStudy, 9);
        }
    }
}