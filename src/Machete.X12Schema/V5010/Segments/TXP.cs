namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface TXP :
        X12Segment
    {
        Value<string> TaxIdentificationNumber { get; }

        Value<string> TaxPaymentTypeCode { get; }

        Value<DateTime> Date { get; }

        Value<string> TaxInformationIdentificationNumber1 { get; }

        Value<string> TaxAmount1 { get; }

        Value<string> TaxInformationIdentificationNumber2 { get; }

        Value<string> TaxAmount2 { get; }

        Value<string> TaxInformationIdentificationNumber3 { get; }

        Value<string> TaxAmount3 { get; }

        Value<string> TaxPayerVerification { get; }
    }
}