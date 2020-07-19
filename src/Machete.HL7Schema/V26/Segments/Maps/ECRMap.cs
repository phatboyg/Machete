// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ECR (SegmentMap) - Equipment Command Response
    /// </summary>
    public class ECRMap :
        HL7V26SegmentMap<ECR>
    {
        public ECRMap()
        {
            Id = "ECR";

            Name = "Equipment Command Response";

            Entity(x => x.CommandResponse, 1, x => x.IsRequired());
            Value(x => x.DateTimeCompleted, 2, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.CommandResponseParameters, 3);
        }
    }
}