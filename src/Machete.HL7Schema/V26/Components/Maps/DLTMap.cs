// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DLT (ComponentMap) - Delta
    /// </summary>
    public class DLTMap :
        HL7V26ComponentMap<DLT>
    {
        public DLTMap()
        {
            Entity(x => x.NormalRange, 0);
            Value(x => x.NumericThreshold, 1);
            Value(x => x.ChangeComputation, 2);
            Value(x => x.DayRetained, 3);
        }
    }
}