namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LEP :
        X12Segment
    {
        Value<string> EPAWasteStreamNumberCode { get; }
        
        Value<string> WasteCharacteristicsCode { get; }
        
        Value<string> StateOrProvinceCode { get; }

        Value<string> ReferenceIdentification { get; }
    }
}