namespace Machete.X12Schema.V5010.Segments
{
    using X12;


    public interface FOB :
        X12Segment
    {
        Value<string> ShipmentMethodOfPayment { get; }
        
        Value<string> LocationQualifier1 { get; }
        
        Value<string> Description1 { get; }
        
        Value<string> TransportationTermsQualifierCode { get; }
        
        Value<string> TransportationTermsCode { get; }
        
        Value<string> LocationQualifier2 { get; }
        
        Value<string> Description2 { get; }
        
        Value<string> RiskOfLossCode { get; }
        
        Value<string> Description3 { get; }
    }
}