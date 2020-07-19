// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FHS (SegmentMap) - File Header
    /// </summary>
    public class FHSMap :
        HL7V26SegmentMap<FHS>
    {
        public FHSMap()
        {
            Id = "FHS";

            Name = "File Header";

            Value(x => x.FileFieldSeparator, 1, x => x.IsRequired());
            Value(x => x.FileEncodingCharacters, 2, x => x.IsRequired());
            Entity(x => x.FileSendingApplication, 3);
            Entity(x => x.FileSendingFacility, 4);
            Entity(x => x.FileReceivingApplication, 5);
            Entity(x => x.FileReceivingFacility, 6);
            Value(x => x.FileCreationDateTime, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.FileSecurity, 8);
            Value(x => x.FileNameId, 9);
            Value(x => x.FileHeaderComment, 10);
            Value(x => x.FileControlId, 11);
            Value(x => x.ReferenceFileControlId, 12);
            Entity(x => x.FileSendingNetworkAddress, 13);
            Entity(x => x.FileReceivingNetworkAddress, 14);
        }
    }
}