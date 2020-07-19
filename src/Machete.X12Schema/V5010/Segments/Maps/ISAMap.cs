namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class ISAMap :
        X12SegmentMap<ISA, X12Entity>
    {
        public ISAMap()
        {
            Id = "ISA";
            Name = "Interchange Control Header";

            Value(x => x.AuthorizationInformationQualifier, 1, x => x.IsRequired().FixedLength(2));
            Value(x => x.AuthorizationInformation, 2, x => x.IsRequired().FixedLength(10));
            Value(x => x.SecurityInformationQualifier, 3, x => x.IsRequired().FixedLength(2));
            Value(x => x.SecurityInformation, 4, x => x.IsRequired().FixedLength(10));
            Value(x => x.SenderIdQualifier, 5, x => x.IsRequired().FixedLength(2));
            Value(x => x.SenderId, 6, x => x.IsRequired().FixedLength(15));
            Value(x => x.ReceiverIdQualifier, 7, x => x.IsRequired().FixedLength(2));
            Value(x => x.ReceiverId, 8, x => x.IsRequired().FixedLength(15));
            Value(x => x.Date, 9, 10, x => x.ShortDateTime().IsRequired());
            Value(x => x.StandardsIdentifier, 11, x => x.IsRequired().FixedLength(1));
            Value(x => x.VersionNumber, 12, x => x.IsRequired().FixedLength(5));
            Value(x => x.ControlNumber, 13, x => x.IsRequired().FixedLength(9));
            Value(x => x.AcknowledgmentRequested, 14, x => x.IsRequired().FixedLength(1));
            Value(x => x.UsageIndicator, 15, x => x.IsRequired().FixedLength(1));
        }
    }
}