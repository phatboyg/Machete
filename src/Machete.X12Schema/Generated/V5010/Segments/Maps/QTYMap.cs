namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class QTYMap : X12SegmentMap<QTY, X12Entity>
    {
        public QTYMap()
        {
            Id = "QTY";
            Name = "Quantity";
            Value(x => x.QuanityQualifier, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.SupplementalInformationQuantity, 2, x => x.MinLength(1).IsRequired());
        }
    }
}