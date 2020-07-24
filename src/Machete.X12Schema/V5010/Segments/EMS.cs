namespace Machete.X12Schema.V5010
{
    using X12;


    public interface EMS :
        X12Segment
    {
        Value<string> Description { get; }
        
        Value<string> EmploymentClassCode { get; }
        
        Value<string> OccupationCode { get; }
        
        Value<string> EmploymentStatusCode { get; }
         
        Value<string> ReferenceIdentificationQualifier { get; }
        
        Value<string> ReferenceIdentification1 { get; }
        
        Value<string> ReferenceIdentification2 { get; }
    }
}