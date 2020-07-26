namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class MTXMap :
        X12SegmentMap<MTX, X12Entity>
    {
        public MTXMap()
        {
            Id = "MTX";
            Name = "Text";
            
            Value(x => x.NoteReferenceCode, 1, x => x.FixedLength(3));
            Value(x => x.TextualData1, 2, x => x.MinLength(1).MaxLength(4096));
            Value(x => x.TextualData2, 3, x => x.MinLength(1).MaxLength(4096));
            Value(x => x.PrinterCarriageControlCode, 4, x => x.FixedLength(2));
            Value(x => x.Number, 5, x => x.MinLength(1).MaxLength(9));
            Value(x => x.LanguageCode, 6, x => x.MinLength(2).MaxLength(3));
        }
    }
}