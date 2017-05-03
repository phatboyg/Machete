// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QRD (SegmentMap) - Original-Style Query Definition
    /// </summary>
    public class QRDMap :
        HL7SegmentMap<QRD>
    {
        public QRDMap()
        {
            Id = "QRD";

            Name = "Original-Style Query Definition";

            Value(x => x.QueryDateTime, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;x.Required = true;});
            Value(x => x.QueryFormatCode, 2, x => {x.Required = true;});
            Value(x => x.QueryPriority, 3, x => {x.Required = true;});
            Value(x => x.QueryId, 4, x => {x.Required = true;});
            Value(x => x.DeferredResponseType, 5);
            Value(x => x.DeferredResponseDateTime, 6, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.QuantityLimitedRequest, 7, x => {x.Required = true;});
            Entity(x => x.WhoSubjectFilter, 8, x => {x.Required = true;});
            Entity(x => x.WhatSubjectFilter, 9, x => {x.Required = true;});
            Entity(x => x.WhatDepartmentDataCode, 10, x => {x.Required = true;});
            Entity(x => x.WhatDataCodeValueQual, 11);
            Value(x => x.QueryResultsLevel, 12);
        }
    }
}