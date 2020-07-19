// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ERR (SegmentMap) - Error
    /// </summary>
    public class ERRMap :
        HL7V26SegmentMap<ERR>
    {
        public ERRMap()
        {
            Id = "ERR";

            Name = "Error";

            Entity(x => x.ErrorCodeAndLocation, 1);
            Entity(x => x.ErrorLocation, 2);
            Entity(x => x.HL7ErrorCode, 3, x => x.IsRequired());
            Value(x => x.Severity, 4, x => x.IsRequired());
            Entity(x => x.ApplicationErrorCode, 5);
            Value(x => x.ApplicationErrorParameter, 6);
            Value(x => x.DiagnosticInformation, 7);
            Value(x => x.UserMessage, 8);
            Value(x => x.InformPersonIndicator, 9);
            Entity(x => x.OverrideType, 10);
            Entity(x => x.OverrideReasonCode, 11);
            Entity(x => x.HelpDeskContactPoint, 12);
        }
    }
}