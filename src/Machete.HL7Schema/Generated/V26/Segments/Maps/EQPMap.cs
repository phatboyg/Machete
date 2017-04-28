// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EQP (SegmentMap) - Equipment/log Service
    /// </summary>
    public class EQPMap :
        HL7SegmentMap<EQP>
    {
        public EQPMap()
        {
            Id = "EQP";

            Name = "Equipment/log Service";

            Entity(x => x.EventType, 1, x => {x.Required = true;});
            Value(x => x.FileName, 2);
            Value(x => x.StartDateTime, 3, x => {x.Format = "LONGDATETIME3";x.Required = true;});
            Value(x => x.EndDateTime, 4, x => {x.Format = "LONGDATETIME4";});
            Value(x => x.TransactionData, 5, x => {x.Required = true;});
        }
    }
}