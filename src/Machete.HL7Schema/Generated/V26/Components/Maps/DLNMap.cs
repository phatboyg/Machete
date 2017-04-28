// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DLN (ComponentMap) - Driver's License Number
    /// </summary>
    public class DLNMap :
        HL7ComponentMap<DLN>
    {
        public DLNMap()
        {
            Value(x => x.LicenseNumber, 1);
            Value(x => x.IssuingStateProvinceCountry, 2);
            Value(x => x.ExpirationDate, 3, x => {x.Format = "LONGDATETIME3";});
        }
    }
}