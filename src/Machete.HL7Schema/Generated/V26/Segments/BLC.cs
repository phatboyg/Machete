// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// BLC (Segment) - Blood Code
    /// </summary>
    public interface BLC :
        HL7V26Segment
    {
        /// <summary>
        /// BLC-1: Blood Product Code
        /// </summary>
        Value<CWE> BloodProductCode { get; }

        /// <summary>
        /// BLC-2: Blood Amount
        /// </summary>
        Value<CQ> BloodAmount { get; }
    }
}