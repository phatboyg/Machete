namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class EFIMap :
        X12SegmentMap<EFI, X12Entity>
    {
        public EFIMap()
        {
            Id = "EFI";
            Name = "Electronic Format Identification";
            
            Value(x => x.SecurityLevelCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.FreeformMessageText, 2, x => x.MinLength(1).MaxLength(264));
            Value(x => x.SecurityTechniqueCode, 3, x => x.FixedLength(2));
            Value(x => x.VersionIdentifier1, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ProgramIdentifier, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.VersionIdentifier2, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.InterchangeFormat, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.VersionIdentifier3, 8, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CompressionTechnique, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.DrawingSheetSizeCode, 10, x => x.FixedLength(2));
            Value(x => x.FileName, 11, x => x.MinLength(1).MaxLength(64));
            Value(x => x.BlockType, 12, x => x.MinLength(1).MaxLength(4));
            Value(x => x.RecordLength, 13, x => x.MinLength(1).MaxLength(15));
            Value(x => x.BlockLength, 14, x => x.MinLength(1).MaxLength(5));
            Value(x => x.VersionIdentifier4, 15, x => x.MinLength(1).MaxLength(30));
            Value(x => x.FilterIdCode, 16, x => x.FixedLength(3));
        }
    }
}