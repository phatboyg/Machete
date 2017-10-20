namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class AMTMap : X12SegmentMap<AMT, X12Entity>
    {
        public AMTMap()
        {
            Id = "AMT";
            Name = "Monetary Amount";
            Value(x => x.AmountQualifierCode, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.SupplementalInformationAmount, 2, x => x.MinLength(1).IsRequired());
        }
    }
}