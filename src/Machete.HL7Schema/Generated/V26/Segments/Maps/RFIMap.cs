// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RFI (SegmentMap) - Request for Information
    /// </summary>
    public class RFIMap :
        HL7SegmentMap<RFI>
    {
        public RFIMap()
        {
            Id = "RFI";

            Name = "Request for Information";

            Value(x => x.RequestDate, 1, x => {x.Format = "LONGDATETIME1";x.Required = true;});
            Value(x => x.ResponseDueDate, 2, x => {x.Format = "LONGDATETIME2";x.Required = true;});
            Value(x => x.PatientConsent, 3);
            Value(x => x.DateAdditionalInformationWasSubmitted, 4, x => {x.Format = "LONGDATETIME4";});
        }
    }
}