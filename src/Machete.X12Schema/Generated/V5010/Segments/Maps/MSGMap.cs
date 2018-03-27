namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class MSGMap :
        X12SegmentMap<MSG, X12Entity>
    {
        public MSGMap()
        {
            Id = "MSG";
            Name = "Message Text";
            
            Value(x => x.FreeFormMessageText, 1, x => x.FixedLength(1));
        }
    }
}