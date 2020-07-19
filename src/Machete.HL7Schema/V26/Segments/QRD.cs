// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// QRD (Segment) - Original-Style Query Definition
    /// </summary>
    public interface QRD :
        HL7V26Segment
    {
        /// <summary>
        /// QRD-1: Query Date/Time
        /// </summary>
        Value<DateTimeOffset> QueryDateTime { get; }

        /// <summary>
        /// QRD-2: Query Format Code
        /// </summary>
        Value<string> QueryFormatCode { get; }

        /// <summary>
        /// QRD-3: Query Priority
        /// </summary>
        Value<string> QueryPriority { get; }

        /// <summary>
        /// QRD-4: Query ID
        /// </summary>
        Value<string> QueryId { get; }

        /// <summary>
        /// QRD-5: Deferred Response Type
        /// </summary>
        Value<string> DeferredResponseType { get; }

        /// <summary>
        /// QRD-6: Deferred Response Date/Time
        /// </summary>
        Value<DateTimeOffset> DeferredResponseDateTime { get; }

        /// <summary>
        /// QRD-7: Quantity Limited Request
        /// </summary>
        Value<CQ> QuantityLimitedRequest { get; }

        /// <summary>
        /// QRD-8: Who Subject Filter
        /// </summary>
        ValueList<XCN> WhoSubjectFilter { get; }

        /// <summary>
        /// QRD-9: What Subject Filter
        /// </summary>
        ValueList<CWE> WhatSubjectFilter { get; }

        /// <summary>
        /// QRD-10: What Department Data Code
        /// </summary>
        ValueList<CWE> WhatDepartmentDataCode { get; }

        /// <summary>
        /// QRD-11: What Data Code Value Qual.
        /// </summary>
        ValueList<VR> WhatDataCodeValueQual { get; }

        /// <summary>
        /// QRD-12: Query Results Level
        /// </summary>
        Value<string> QueryResultsLevel { get; }
    }
}