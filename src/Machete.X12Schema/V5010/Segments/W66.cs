namespace Machete.X12Schema.V5010
{
    using X12;


    public interface W66 :
        X12Segment
    {
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> TransportationMethodOrTypeCode { get; }
        
        Value<string> PalletExchangeCode { get; }
        
        Value<string> UnitLoadOptionCode { get; }
        
        Value<string> Routing { get; }
        
        Value<string> FreeOnBoardPointCode { get; }
        
        Value<string> FreeOnBoardPoint { get; }
        
        Value<string> CashOnDeliveryMethodOfPaymentCode { get; }
        
        Value<string> Amount { get; }
        
        Value<string> StandardCarrierAlphaCode { get; }
    }
}