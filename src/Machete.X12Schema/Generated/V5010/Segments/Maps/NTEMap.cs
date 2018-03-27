namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class NTEMap :
        X12SegmentMap<NTE, X12Entity>
    {
        public NTEMap()
        {
            Id = "NTE";
            Name = "Note Or Special Instruction";
            
            Value(x => x.NoteReferenceCode, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.NoteDescription, 2, x => x.MinLength(1).MaxLength(80).IsRequired());
        }
    }
}