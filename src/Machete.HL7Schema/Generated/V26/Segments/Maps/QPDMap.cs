// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QPD (SegmentMap) - Query Parameter Definition
    /// </summary>
    public class QPDMap :
        HL7V26SegmentMap<QPD>
    {
        public QPDMap()
        {
            Id = "QPD";

            Name = "Query Parameter Definition";

            Entity(x => x.MessageQueryName, 1, x => {x.Required = true;});
            Value(x => x.QueryTag, 2);
            Value(x => x.UserParametersInSuccessivefields, 3);
        }
    }
}