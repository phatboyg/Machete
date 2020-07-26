namespace Machete.X12Schema.V5010
{
    using X12;


    public interface TAX :
        X12Segment
    {
        Value<string> TaxIdentificationNumber { get; }
        
        Value<string> LocationQualifier1 { get; }
        
        Value<string> LocationIdentifier1 { get; }
        
        Value<string> LocationQualifier2 { get; }
        
        Value<string> LocationIdentifier2 { get; }
        
        Value<string> LocationQualifier3 { get; }
        
        Value<string> LocationIdentifier3 { get; }
        
        Value<string> LocationQualifier4 { get; }
        
        Value<string> LocationIdentifier4 { get; }
        
        Value<string> LocationQualifier5 { get; }
        
        Value<string> LocationIdentifier5 { get; }
        
        Value<string> TaxExemptCode { get; }
        
        Value<string> CustomsEntryTypeGroupCode { get; }
    }
}