// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PSH (SegmentMap) - Product Summary Header
    /// </summary>
    public class PSHMap :
        HL7V26SegmentMap<PSH>
    {
        public PSHMap()
        {
            Id = "PSH";

            Name = "Product Summary Header";

            Value(x => x.ReportType, 1, x => x.IsRequired());
            Value(x => x.ReportFormIdentifier, 2);
            Value(x => x.ReportDate, 3, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.ReportIntervalStartDate, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ReportIntervalEndDate, 5, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.QuantityManufactured, 6);
            Entity(x => x.QuantityDistributed, 7);
            Value(x => x.QuantityDistributedMethod, 8);
            Value(x => x.QuantityDistributedComment, 9);
            Entity(x => x.QuantityInUse, 10);
            Value(x => x.QuantityInUseMethod, 11);
            Value(x => x.QuantityInUseComment, 12);
            Value(x => x.NumberOfProductExperienceReportsFiledByFacility, 13);
            Value(x => x.NumberOfProductExperienceReportsFiledByDistributor, 14);
        }
    }
}