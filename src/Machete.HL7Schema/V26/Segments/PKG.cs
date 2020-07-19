// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PKG (Segment) - Item Packaging
    /// </summary>
    public interface PKG :
        HL7V26Segment
    {
        /// <summary>
        /// PKG-1: Set Id - PKG
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// PKG-2: Packaging Units
        /// </summary>
        Value<CWE> PackagingUnits { get; }

        /// <summary>
        /// PKG-3: Default Order Unit Of Measure Indicator
        /// </summary>
        Value<CNE> DefaultOrderUnitOfMeasureIndicator { get; }

        /// <summary>
        /// PKG-4: Package Quantity
        /// </summary>
        Value<decimal> PackageQuantity { get; }

        /// <summary>
        /// PKG-5: Price
        /// </summary>
        Value<CP> Price { get; }

        /// <summary>
        /// PKG-6: Future Item Price
        /// </summary>
        Value<CP> FutureItemPrice { get; }

        /// <summary>
        /// PKG-7: Future Item Price Effective Date
        /// </summary>
        Value<DateTimeOffset> FutureItemPriceEffectiveDate { get; }
    }
}