// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CDM (Segment) - Charge Description Master
    /// </summary>
    public interface CDM :
        HL7V26Segment
    {
        /// <summary>
        /// CDM-1: Primary Key Value - CDM
        /// </summary>
        Value<CWE> PrimaryKeyValue { get; }

        /// <summary>
        /// CDM-2: Charge Code Alias
        /// </summary>
        ValueList<CWE> ChargeCodeAlias { get; }

        /// <summary>
        /// CDM-3: Charge Description Short
        /// </summary>
        Value<string> ChargeDescriptionShort { get; }

        /// <summary>
        /// CDM-4: Charge Description Long
        /// </summary>
        Value<string> ChargeDescriptionLong { get; }

        /// <summary>
        /// CDM-5: Description Override Indicator
        /// </summary>
        Value<string> DescriptionOverrideIndicator { get; }

        /// <summary>
        /// CDM-6: Exploding Charges
        /// </summary>
        ValueList<CWE> ExplodingCharges { get; }

        /// <summary>
        /// CDM-7: Procedure Code
        /// </summary>
        ValueList<CNE> ProcedureCode { get; }

        /// <summary>
        /// CDM-8: Active/Inactive Flag
        /// </summary>
        Value<string> ActiveInactiveFlag { get; }

        /// <summary>
        /// CDM-9: Inventory Number
        /// </summary>
        ValueList<CWE> InventoryNumber { get; }

        /// <summary>
        /// CDM-10: Resource Load
        /// </summary>
        Value<decimal> ResourceLoad { get; }

        /// <summary>
        /// CDM-11: Contract Number
        /// </summary>
        ValueList<CX> ContractNumber { get; }

        /// <summary>
        /// CDM-12: Contract Organization
        /// </summary>
        ValueList<XON> ContractOrganization { get; }

        /// <summary>
        /// CDM-13: Room Fee Indicator
        /// </summary>
        Value<string> RoomFeeIndicator { get; }
    }
}