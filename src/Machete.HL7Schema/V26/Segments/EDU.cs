// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// EDU (Segment) - Educational Detail
    /// </summary>
    public interface EDU :
        HL7V26Segment
    {
        /// <summary>
        /// EDU-1: Set ID - EDU
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// EDU-2: Academic Degree
        /// </summary>
        Value<string> AcademicDegree { get; }

        /// <summary>
        /// EDU-3: Academic Degree Program Date Range
        /// </summary>
        Value<DR> AcademicDegreeProgramDateRange { get; }

        /// <summary>
        /// EDU-4: Academic Degree Program Participation Date Range
        /// </summary>
        Value<DR> AcademicDegreeProgramParticipationDateRange { get; }

        /// <summary>
        /// EDU-5: Academic Degree Granted Date
        /// </summary>
        Value<DateTimeOffset> AcademicDegreeGrantedDate { get; }

        /// <summary>
        /// EDU-6: School
        /// </summary>
        Value<XON> School { get; }

        /// <summary>
        /// EDU-7: School Type Code
        /// </summary>
        Value<CWE> SchoolTypeCode { get; }

        /// <summary>
        /// EDU-8: School Address
        /// </summary>
        Value<XAD> SchoolAddress { get; }

        /// <summary>
        /// EDU-9: Major Field of Study
        /// </summary>
        ValueList<CWE> MajorFieldOfStudy { get; }
    }
}