namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class GSMap :
        X12SegmentMap<GS, X12Entity>
    {
        public GSMap()
        {
            Id = "GS";
            Name = "Functional Group";

            Value(x => x.FunctionalIdentifierCode, 1, x => x.IsRequired().FixedLength(2));
            Value(x => x.ApplicationSendersCode, 2, x => x.IsRequired().MinLength(2).MaxLength(15));
            Value(x => x.ApplicationReceiversCode, 3, x => x.IsRequired().MinLength(2).MaxLength(15));

//            Value(x => x.Date, 1, x => x.IsRequired().FixedLength(2));

            Value(x => x.ControlNumber, 6, x => x.IsRequired().MaxLength(9));
            Value(x => x.ResponsibleAgencyCode, 7, x => x.IsRequired().MaxLength(2));
            Value(x => x.VersionIdentifierCode, 8, x => x.IsRequired().MaxLength(12));
        }
    }
}