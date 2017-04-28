// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPN (ComponentMap) - Performing Person Time Stamp
    /// </summary>
    public class PPNMap :
        HL7ComponentMap<PPN>
    {
        public PPNMap()
        {
            Value(x => x.IdNumber, 1);
            Entity(x => x.FamilyName, 2);
            Value(x => x.GivenName, 3);
            Value(x => x.MiddleInitialOrName, 4);
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
            Value(x => x.DateTimeActionPerformed, 15, x => {x.Format = "LONGDATETIME15";});
            Value(x => x.NameRepresentationCode, 16);
            Entity(x => x.NameContext, 17);
            Entity(x => x.NameValidityRange, 18);
            Value(x => x.NameAssemblyOrder, 19);
            Value(x => x.EffectiveDate, 20, x => {x.Format = "LONGDATETIME20";});
            Value(x => x.ExpirationDate, 21, x => {x.Format = "LONGDATETIME21";});
            Value(x => x.ProfessionalSuffix, 22);
            Entity(x => x.AssigningJurisdiction, 23);
            Entity(x => x.AssigningAgencyOrDepartment, 24);
        }
    }
}