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
        HL7ComponentMap<XPN>
    {
        public XPNMap()
        {
            Entity(x => x.FamilyName, 1);
            Value(x => x.GivenName, 2);
            Value(x => x.SecondAndFurtherGivenNamesOrInitialsreof, 3);
            Value(x => x.Suffix, 4);
            Value(x => x.Prefix, 5);
            Value(x => x.Degree, 6);
            Value(x => x.NameTypeCode, 7);
            Value(x => x.NameRepresentationCode, 8);
            Entity(x => x.NameContext, 9);
            Entity(x => x.NameValidityRange, 10);
            Value(x => x.NameAssemblyOrder, 11);
            Value(x => x.EffectiveDate, 12, x => {x.Format = "LONGDATETIME12";});
            Value(x => x.ExpirationDate, 13, x => {x.Format = "LONGDATETIME13";});
            Value(x => x.ProfessionalSuffix, 14);
        }
    }
}