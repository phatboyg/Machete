// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// XCN (ComponentMap) - Extended Composite ID Number and Name for Persons
    /// </summary>
    public class XCNMap :
        HL7V26ComponentMap<XCN>
    {
        public XCNMap()
        {
            Value(x => x.IdNumber, 0);
            Entity(x => x.FamilyName, 1);
            Value(x => x.GivenName, 2);
            Value(x => x.SecondAndFurtherGivenNamesOrInitialsThereof, 3);
            Value(x => x.Suffix, 4);
            Value(x => x.Prefix, 5);
            Value(x => x.Degree, 6);
            Value(x => x.SourceTable, 7);
            Entity(x => x.AssigningAuthority, 8);
            Value(x => x.NameTypeCode, 9);
            Value(x => x.IdentifierCheckDigit, 10);
            Value(x => x.CheckDigitScheme, 11);
            Value(x => x.IdentifierTypeCode, 12);
            Entity(x => x.AssigningFacility, 13);
            Value(x => x.NameRepresentationCode, 14);
            Entity(x => x.NameContext, 15);
            Entity(x => x.NameValidityRange, 16);
            Value(x => x.NameAssemblyOrder, 17);
            Value(x => x.EffectiveDate, 18, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpirationDate, 19, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ProfessionalSuffix, 20);
            Entity(x => x.AssigningJurisdiction, 21);
            Entity(x => x.AssigningAgencyOrDepartment, 22);
        }
    }
}