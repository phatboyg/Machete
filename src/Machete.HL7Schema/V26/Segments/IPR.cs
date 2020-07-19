// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// IPR (Segment) - Invoice Processing Results
    /// </summary>
    public interface IPR :
        HL7V26Segment
    {
        /// <summary>
        /// IPR-1: IPR Identifier
        /// </summary>
        Value<EI> IPRIdentifier { get; }

        /// <summary>
        /// IPR-2: Provider Cross Reference Identifier
        /// </summary>
        Value<EI> ProviderCrossReferenceIdentifier { get; }

        /// <summary>
        /// IPR-3: Payer Cross Reference Identifier
        /// </summary>
        Value<EI> PayerCrossReferenceIdentifier { get; }

        /// <summary>
        /// IPR-4: IPR Status
        /// </summary>
        Value<CWE> IPRStatus { get; }

        /// <summary>
        /// IPR-5: IPR Date/Time
        /// </summary>
        Value<DateTimeOffset> IPRDateTime { get; }

        /// <summary>
        /// IPR-6: Adjudicated/Paid Amount
        /// </summary>
        Value<CP> AdjudicatedPaidAmount { get; }

        /// <summary>
        /// IPR-7: Expected Payment Date/Time
        /// </summary>
        Value<DateTimeOffset> ExpectedPaymentDateTime { get; }

        /// <summary>
        /// IPR-8: IPR Checksum
        /// </summary>
        Value<string> IPRChecksum { get; }
    }
}