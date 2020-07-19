// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PRC (Segment) - Pricing
    /// </summary>
    public interface PRC :
        HL7V26Segment
    {
        /// <summary>
        /// PRC-1: Primary Key Value-PRC
        /// </summary>
        Value<CWE> PrimaryKeyValue { get; }

        /// <summary>
        /// PRC-2: Facility ID-PRC
        /// </summary>
        ValueList<CWE> FacilityId { get; }

        /// <summary>
        /// PRC-3: Department
        /// </summary>
        ValueList<CWE> Department { get; }

        /// <summary>
        /// PRC-4: Valid Patient Classes
        /// </summary>
        ValueList<string> ValidPatientClasses { get; }

        /// <summary>
        /// PRC-5: Price
        /// </summary>
        ValueList<CP> Price { get; }

        /// <summary>
        /// PRC-6: Formula
        /// </summary>
        ValueList<string> Formula { get; }

        /// <summary>
        /// PRC-7: Minimum Quantity
        /// </summary>
        Value<decimal> MinimumQuantity { get; }

        /// <summary>
        /// PRC-8: Maximum Quantity
        /// </summary>
        Value<decimal> MaximumQuantity { get; }

        /// <summary>
        /// PRC-9: Minimum Price
        /// </summary>
        Value<MO> MinimumPrice { get; }

        /// <summary>
        /// PRC-10: Maximum Price
        /// </summary>
        Value<MO> MaximumPrice { get; }

        /// <summary>
        /// PRC-11: Effective Start Date
        /// </summary>
        Value<DateTimeOffset> EffectiveStartDate { get; }

        /// <summary>
        /// PRC-12: Effective End Date
        /// </summary>
        Value<DateTimeOffset> EffectiveEndDate { get; }

        /// <summary>
        /// PRC-13: Price Override Flag
        /// </summary>
        Value<string> PriceOverrideFlag { get; }

        /// <summary>
        /// PRC-14: Billing Category
        /// </summary>
        ValueList<CWE> BillingCategory { get; }

        /// <summary>
        /// PRC-15: Chargeable Flag
        /// </summary>
        Value<string> ChargeableFlag { get; }

        /// <summary>
        /// PRC-16: Active/Inactive Flag
        /// </summary>
        Value<string> ActiveInactiveFlag { get; }

        /// <summary>
        /// PRC-17: Cost
        /// </summary>
        Value<MO> Cost { get; }

        /// <summary>
        /// PRC-18: Charge on Indicator
        /// </summary>
        Value<string> ChargeOnIndicator { get; }
    }
}