namespace Machete.X12Schema.V5010
{
    using X12;


    public interface EFI :
        X12Segment
    {
        Value<string> SecurityLevelCode { get; }
        
        Value<string> FreeformMessageText { get; }
        
        Value<string> SecurityTechniqueCode { get; }
        
        Value<string> VersionIdentifier1 { get; }
        
        Value<string> ProgramIdentifier { get; }
        
        Value<string> VersionIdentifier2 { get; }
        
        Value<string> InterchangeFormat { get; }
        
        Value<string> VersionIdentifier3 { get; }
        
        Value<string> CompressionTechnique { get; }
        
        Value<string> DrawingSheetSizeCode { get; }
        
        Value<string> FileName { get; }
        
        Value<string> BlockType { get; }
        
        Value<string> RecordLength { get; }
        
        Value<string> BlockLength { get; }
        
        Value<string> VersionIdentifier4 { get; }
        
        Value<string> FilterIdCode { get; }
    }
}