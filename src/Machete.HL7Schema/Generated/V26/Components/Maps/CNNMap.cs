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
        HL7V26ComponentMap<CNN>
    {
        public CNNMap()
        {
            Value(x => x.IdNumber, 0);
            Value(x => x.FamilyName, 1);
            Value(x => x.GivenName, 2);
            Value(x => x.SecondAndFurtherGivenNamesOrInitialsThereof, 3);
            Value(x => x.Suffix, 4);
            Value(x => x.Prefix, 5);
            Value(x => x.Degree, 6);
            Value(x => x.SourceTable, 7);
            Value(x => x.AssigningAuthorityNamespaceId, 8);
            Value(x => x.AssigningAuthorityUniversalId, 9);
            Value(x => x.AssigningAuthorityUniversalIdType, 10);
        }
    }
}