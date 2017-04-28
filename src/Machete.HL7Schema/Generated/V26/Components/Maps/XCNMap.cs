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
        HL7ComponentMap<XCN>
    {
        public XCNMap()
        {
            Value(x => x.IdNumber, 1);
            Entity(x => x.FamilyName, 2);
            Value(x => x.GivenName, 3);
            Value(x => x.SecondAndFurtherGivenNamesOrInitialsreof, 4);
            Value(x => x.Suffix, 5);
            Value(x => x.Prefix, 6);
            Value(x => x.Degree, 7);
            Value(x => x.SourceTable, 8);
            Entity(x => x.AssigningAuthority, 9);
            Value(x => x.NameTypeCode, 10);
            Value(x => x.IdentifierCheckDigit, 11);
            Value(x => x.CheckDigitScheme, 12);
            Value(x => x.IdentifierTypeCode, 13);
            Entity(x => x.AssigningFacility, 14);
            Value(x => x.NameRepresentationCode, 15);
            Entity(x => x.NameContext, 16);
            Entity(x => x.NameValidityRange, 17);
            Value(x => x.NameAssemblyOrder, 18);
            Value(x => x.EffectiveDate, 19, x => {x.Format = "LONGDATETIME19";});
            Value(x => x.ExpirationDate, 20, x => {x.Format = "LONGDATETIME20";});
            Value(x => x.ProfessionalSuffix, 21);
            Entity(x => x.AssigningJurisdiction, 22);
            Entity(x => x.AssigningAgencyOrDepartment, 23);
        }
    }
}