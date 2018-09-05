// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// XPN (ComponentMap) - Extended Person Name
    /// </summary>
    public class XPNMap :
        HL7V26ComponentMap<XPN>
    {
        public XPNMap()
        {
            Entity(x => x.FamilyName, 0);
            Value(x => x.GivenName, 1);
            Value(x => x.SecondAndFurtherGivenNamesOrInitialsThereof, 2);
            Value(x => x.Suffix, 3);
            Value(x => x.Prefix, 4);
            Value(x => x.Degree, 5);
            Value(x => x.NameTypeCode, 6);
            Value(x => x.NameRepresentationCode, 7);
            Entity(x => x.NameContext, 8);
            Entity(x => x.NameValidityRange, 9);
            Value(x => x.NameAssemblyOrder, 10);
            Value(x => x.EffectiveDate, 11, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 12, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ProfessionalSuffix, 13);
        }
    }
}