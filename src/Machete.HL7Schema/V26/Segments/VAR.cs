// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// VAR (Segment) - Variance
    /// </summary>
    public interface VAR :
        HL7V26Segment
    {
        /// <summary>
        /// VAR-1: Variance Instance ID
        /// </summary>
        Value<EI> VarianceInstanceId { get; }

        /// <summary>
        /// VAR-2: Documented Date/Time
        /// </summary>
        Value<DateTimeOffset> DocumentedDateTime { get; }

        /// <summary>
        /// VAR-3: Stated Variance Date/Time
        /// </summary>
        Value<DateTimeOffset> StatedVarianceDateTime { get; }

        /// <summary>
        /// VAR-4: Variance Originator
        /// </summary>
        ValueList<XCN> VarianceOriginator { get; }

        /// <summary>
        /// VAR-5: Variance Classification
        /// </summary>
        Value<CWE> VarianceClassification { get; }

        /// <summary>
        /// VAR-6: Variance Description
        /// </summary>
        ValueList<string> VarianceDescription { get; }
    }
}