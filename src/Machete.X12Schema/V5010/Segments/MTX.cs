namespace Machete.X12Schema.V5010
{
    using X12;


    public interface MTX :
        X12Segment
    {
        Value<string> NoteReferenceCode { get; }
        
        Value<string> TextualData1 { get; }
        
        Value<string> TextualData2 { get; }
        
        Value<string> PrinterCarriageControlCode { get; }
        
        Value<string> Number { get; }
        
        Value<string> LanguageCode { get; }
    }
}