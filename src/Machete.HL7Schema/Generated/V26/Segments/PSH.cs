// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// PSH (Segment) - Product Summary Header
    /// </summary>
    public interface PSH :
        HL7Segment
    {
        /// <summary>
        /// PSH-1: Report Type
        /// </summary>
        Value<string> ReportType { get; }

        /// <summary>
        /// PSH-2: Report Form Identifier
        /// </summary>
        Value<string> ReportFormIdentifier { get; }

        /// <summary>
        /// PSH-3: Report Date
        /// </summary>
        Value<DateTimeOffset> ReportDate { get; }

        /// <summary>
        /// PSH-4: Report Interval Start Date
        /// </summary>
        Value<DateTimeOffset> ReportIntervalStartDate { get; }

        /// <summary>
        /// PSH-5: Report Interval End Date
        /// </summary>
        Value<DateTimeOffset> ReportIntervalEndDate { get; }

        /// <summary>
        /// PSH-6: Quantity Manufactured
        /// </summary>
        Value<CQ> QuantityManufactured { get; }

        /// <summary>
        /// PSH-7: Quantity Distributed
        /// </summary>
        Value<CQ> QuantityDistributed { get; }

        /// <summary>
        /// PSH-8: Quantity Distributed Method
        /// </summary>
        Value<string> QuantityDistributedMethod { get; }

        /// <summary>
        /// PSH-9: Quantity Distributed Comment
        /// </summary>
        Value<FT> QuantityDistributedComment { get; }

        /// <summary>
        /// PSH-10: Quantity in Use
        /// </summary>
        Value<CQ> QuantityInUse { get; }

        /// <summary>
        /// PSH-11: Quantity in Use Method
        /// </summary>
        Value<string> QuantityInUseMethod { get; }

        /// <summary>
        /// PSH-12: Quantity in Use Comment
        /// </summary>
        Value<FT> QuantityInUseComment { get; }

        /// <summary>
        /// PSH-13: Number of Product Experience Reports Filed by Facility
        /// </summary>
        Value<decimal> NumberOfProductExperienceReportsFiledByFacility { get; }

        /// <summary>
        /// PSH-14: Number of Product Experience Reports Filed by Distributor
        /// </summary>
        Value<decimal> NumberOfProductExperienceReportsFiledByDistributor { get; }
    }
}