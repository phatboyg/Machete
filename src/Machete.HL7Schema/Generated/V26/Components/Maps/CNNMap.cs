// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CNN (ComponentMap) - Composite ID Number and Name Simplified
    /// </summary>
    public class CNNMap :
        HL7ComponentMap<CNN>
    {
        public CNNMap()
        {
            Value(x => x.IdNumber, 1);
            Value(x => x.FamilyName, 2);
            Value(x => x.GivenName, 3);
            Value(x => x.SecondAndFurtherGivenNamesOrInitialsreof, 4);
            Value(x => x.Suffix, 5);
            Value(x => x.Prefix, 6);
            Value(x => x.Degree, 7);
            Value(x => x.SourceTable, 8);
            Value(x => x.AssigningAuthorityNamespaceId, 9);
            Value(x => x.AssigningAuthorityUniversalId, 10);
            Value(x => x.AssigningAuthorityUniversalIdType, 11);
        }
    }
}