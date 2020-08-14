namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L5 :
        X12Segment
    {
        Value<int> LadingLineItemNumber { get; }
        
        Value<string> LadingDescription { get; }
        
        Value<string> CommodityCode1 { get; }
        
        Value<string> CommodityCodeQualifier1 { get; }
        
        Value<string> PackagingCode { get; }
        
        Value<string> MarksAndNumbers { get; }
        
        Value<string> MarksAndNumbersQualifier { get; }
        
        Value<string> CommodityCodeQualifier2 { get; }
        
        Value<string> CommodityCode2 { get; }
        
        Value<string> CompartmentIdCode { get; }
    }
}