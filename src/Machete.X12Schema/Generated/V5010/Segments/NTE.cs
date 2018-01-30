namespace Machete.X12Schema.V5010
{
    using X12;
    
    
    public interface NTE :
        X12Segment
    {
        Value<string> NoteReferenceCode { get; }

        Value<string> NoteDescription { get; }
    }
}