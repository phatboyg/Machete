// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ICD (ComponentMap) - Insurance Certification Definition
    /// </summary>
    public class ICDMap :
        HL7ComponentMap<ICD>
    {
        public ICDMap()
        {
            Value(x => x.CertificationPatientType, 1);
            Value(x => x.CertificationRequired, 2);
            Value(x => x.DateTimeCertificationRequired, 3, x => {x.Format = "LONGDATETIME3";});
        }
    }
}