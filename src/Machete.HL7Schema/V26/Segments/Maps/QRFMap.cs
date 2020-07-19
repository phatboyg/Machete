// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QRF (SegmentMap) - Original style query filter
    /// </summary>
    public class QRFMap :
        HL7V26SegmentMap<QRF>
    {
        public QRFMap()
        {
            Id = "QRF";

            Name = "Original style query filter";

            Value(x => x.WhereSubjectFilter, 1, x => x.IsRequired());
            Value(x => x.WhenDataStartDateTime, 2, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.WhenDataEndDateTime, 3, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.WhatUserQualifier, 4);
            Value(x => x.OtherQRYSubjectFilter, 5);
            Value(x => x.WhichDateTimeQualifier, 6);
            Value(x => x.WhichDateTimeStatusQualifier, 7);
            Value(x => x.DateTimeSelectionQualifier, 8);
            Entity(x => x.WhenQuantityTimingQualifier, 9);
            Value(x => x.SearchConfidenceThreshold, 10);
        }
    }
}