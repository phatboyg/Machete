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
            Value(x => x.IdNumber, 0);
            Entity(x => x.FamilyName, 1);
            Value(x => x.GivenName, 2);
            Value(x => x.MiddleInitialOrName, 3);
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
            Value(x => x.DateTimeActionPerformed, 14, x => {x.Format = "LONGDATETIME15";});
            Value(x => x.NameRepresentationCode, 15);
            Entity(x => x.NameContext, 16);
            Entity(x => x.NameValidityRange, 17);
            Value(x => x.NameAssemblyOrder, 18);
            Value(x => x.EffectiveDate, 19, x => {x.Format = "LONGDATETIME20";});
            Value(x => x.ExpirationDate, 20, x => {x.Format = "LONGDATETIME21";});
            Value(x => x.ProfessionalSuffix, 21);
            Entity(x => x.AssigningJurisdiction, 22);
            Entity(x => x.AssigningAgencyOrDepartment, 23);
        }
    }
}