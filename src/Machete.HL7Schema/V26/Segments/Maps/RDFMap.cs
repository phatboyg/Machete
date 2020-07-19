// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDF (SegmentMap) - Table Row Definition
    /// </summary>
    public class RDFMap :
        HL7V26SegmentMap<RDF>
    {
        public RDFMap()
        {
            Id = "RDF";

            Name = "Table Row Definition";

            Value(x => x.NumberOfColumnsPerRow, 1, x => x.IsRequired());
            Entity(x => x.ColumnDescription, 2, x => x.IsRequired());
        }
    }
}