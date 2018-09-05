// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SFT (SegmentMap) - Software Segment
    /// </summary>
    public class SFTMap :
        HL7V26SegmentMap<SFT>
    {
        public SFTMap()
        {
            Id = "SFT";

            Name = "Software Segment";

            Entity(x => x.SoftwareVendorOrganization, 1, x => x.IsRequired());
            Value(x => x.SoftwareCertifiedVersionOrReleaseNumber, 2, x => x.IsRequired());
            Value(x => x.SoftwareProductName, 3, x => x.IsRequired());
            Value(x => x.SoftwareBinaryId, 4, x => x.IsRequired());
            Value(x => x.SoftwareProductInformation, 5);
            Value(x => x.SoftwareInstallDate, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}