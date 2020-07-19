// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// ACC (Segment) - Accident
    /// </summary>
    public interface ACC :
        HL7V26Segment
    {
        /// <summary>
        /// ACC-1: Accident Date/Time
        /// </summary>
        Value<DateTimeOffset> AccidentDateTime { get; }

        /// <summary>
        /// ACC-2: Accident Code
        /// </summary>
        Value<CWE> AccidentCode { get; }

        /// <summary>
        /// ACC-3: Accident Location
        /// </summary>
        Value<string> AccidentLocation { get; }

        /// <summary>
        /// ACC-4: Auto Accident State
        /// </summary>
        Value<CWE> AutoAccidentState { get; }

        /// <summary>
        /// ACC-5: Accident Job Related Indicator
        /// </summary>
        Value<string> AccidentJobRelatedIndicator { get; }

        /// <summary>
        /// ACC-6: Accident Death Indicator
        /// </summary>
        Value<string> AccidentDeathIndicator { get; }

        /// <summary>
        /// ACC-7: Entered By
        /// </summary>
        Value<XCN> EnteredBy { get; }

        /// <summary>
        /// ACC-8: Accident Description
        /// </summary>
        Value<string> AccidentDescription { get; }

        /// <summary>
        /// ACC-9: Brought In By
        /// </summary>
        Value<string> BroughtInBy { get; }

        /// <summary>
        /// ACC-10: Police Notified Indicator
        /// </summary>
        Value<string> PoliceNotifiedIndicator { get; }

        /// <summary>
        /// ACC-11: Accident Address
        /// </summary>
        Value<XAD> AccidentAddress { get; }
    }
}