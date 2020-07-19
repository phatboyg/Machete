// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// PYE (Segment) - Payee Information
    /// </summary>
    public interface PYE :
        HL7V26Segment
    {
        /// <summary>
        /// PYE-1: Set ID - PYE
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// PYE-2: Payee Type
        /// </summary>
        Value<string> PayeeType { get; }

        /// <summary>
        /// PYE-3: Payee Relationship to Invoice (Patient)
        /// </summary>
        Value<string> PayeeRelationshipToInvoicePatient { get; }

        /// <summary>
        /// PYE-4: Payee Identification List
        /// </summary>
        Value<XON> PayeeIdentificationList { get; }

        /// <summary>
        /// PYE-5: Payee Person Name
        /// </summary>
        Value<XPN> PayeePersonName { get; }

        /// <summary>
        /// PYE-6: Payee Address
        /// </summary>
        Value<XAD> PayeeAddress { get; }

        /// <summary>
        /// PYE-7: Payment Method
        /// </summary>
        Value<string> PaymentMethod { get; }
    }
}