// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PLN (ComponentMap) - Practitioner License or Other ID Number
    /// </summary>
    public class PLNMap :
        HL7V26ComponentMap<PLN>
    {
        public PLNMap()
        {
            Value(x => x.IdNumber, 0);
            Value(x => x.TypeOfIdNumber, 1);
            Value(x => x.StateOtherQualifyingInformation, 2);
            Value(x => x.ExpirationDate, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}