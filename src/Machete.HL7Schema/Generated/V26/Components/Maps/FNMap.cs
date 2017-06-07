// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FN (ComponentMap) - Family Name
    /// </summary>
    public class FNMap :
        HL7V26ComponentMap<FN>
    {
        public FNMap()
        {
            Value(x => x.Surname, 0);
            Value(x => x.OwnSurnamePrefix, 1);
            Value(x => x.OwnSurname, 2);
            Value(x => x.SurnamePrefixFromPartnerSpouse, 3);
            Value(x => x.SurnameFromPartnerSpouse, 4);
        }
    }
}