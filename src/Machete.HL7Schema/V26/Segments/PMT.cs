// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PMT (Segment) - Payment Information
    /// </summary>
    public interface PMT :
        HL7V26Segment
    {
        /// <summary>
        /// PMT-1: Payment/Remittance Advice Number
        /// </summary>
        Value<EI> PaymentRemittanceAdviceNumber { get; }

        /// <summary>
        /// PMT-2: Payment/Remittance Effective Date/Time
        /// </summary>
        Value<DateTimeOffset> PaymentRemittanceEffectiveDateTime { get; }

        /// <summary>
        /// PMT-3: Payment/Remittance Expiration Date/Time
        /// </summary>
        Value<DateTimeOffset> PaymentRemittanceExpirationDateTime { get; }

        /// <summary>
        /// PMT-4: Payment Method
        /// </summary>
        Value<CWE> PaymentMethod { get; }

        /// <summary>
        /// PMT-5: Payment/Remittance Date/Time
        /// </summary>
        Value<DateTimeOffset> PaymentRemittanceDateTime { get; }

        /// <summary>
        /// PMT-6: Payment/Remittance Amount
        /// </summary>
        Value<CP> PaymentRemittanceAmount { get; }

        /// <summary>
        /// PMT-7: Check Number
        /// </summary>
        Value<EI> CheckNumber { get; }

        /// <summary>
        /// PMT-8: Payee Bank Identification
        /// </summary>
        Value<XON> PayeeBankIdentification { get; }

        /// <summary>
        /// PMT-9: Payee Transit Number
        /// </summary>
        Value<string> PayeeTransitNumber { get; }

        /// <summary>
        /// PMT-10: Payee Bank Account ID
        /// </summary>
        Value<CX> PayeeBankAccountId { get; }

        /// <summary>
        /// PMT-11: Payment Organization
        /// </summary>
        Value<XON> PaymentOrganization { get; }

        /// <summary>
        /// PMT-12: ESR-Code-Line
        /// </summary>
        Value<string> ESRCodeLine { get; }
    }
}