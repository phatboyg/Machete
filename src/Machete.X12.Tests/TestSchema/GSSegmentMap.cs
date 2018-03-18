namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class GSSegmentMap :
        X12SegmentMap<GSSegment, X12Entity>
    {
        public GSSegmentMap()
        {
            Id = "GS";
            Name = "Functional Group";

            Value(x => x.FunctionalIdentifierCode, 1, x => x.IsRequired().FixedLength(2));
            Value(x => x.ApplicationSendersCode, 2, x => x.IsRequired().MinLength(2).MaxLength(15));
            Value(x => x.ApplicationReceiversCode, 3, x => x.IsRequired().MinLength(2).MaxLength(15));
            Value(x => x.ControlNumber, 6, x => x.IsRequired().MaxLength(9));
            Value(x => x.ResponsibleAgencyCode, 7, x => x.IsRequired().MaxLength(2));
            Value(x => x.VersionIdentifierCode, 8, x => x.IsRequired().MaxLength(12));
        }
    }
}