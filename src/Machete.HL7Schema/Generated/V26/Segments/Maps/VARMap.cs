// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VAR (SegmentMap) - Variance
    /// </summary>
    public class VARMap :
        HL7V26SegmentMap<VAR>
    {
        public VARMap()
        {
            Id = "VAR";

            Name = "Variance";

            Entity(x => x.VarianceInstanceId, 1, x => x.IsRequired());
            Value(x => x.DocumentedDateTime, 2, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.StatedVarianceDateTime, 3, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.VarianceOriginator, 4);
            Entity(x => x.VarianceClassification, 5);
            Value(x => x.VarianceDescription, 6);
        }
    }
}