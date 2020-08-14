namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface ZC1 :
        X12Segment
    {
        Value<string> ShipmentIdentificationNumber { get; }

        Value<string> EquipmentInitial { get; }

        Value<string> EquipmentNumber { get; }

        Value<string> TransactionReferenceNumber { get; }

        Value<DateTime> TransactionReferenceDate { get; }

        Value<String> CorrectionIndicator { get; }

        Value<string> StandardCarrierAlphaCode { get; }

        Value<string> TransportationMethodCode { get; }

        Value<int> EquipmentNumberCheckDigit { get; }
    }
}