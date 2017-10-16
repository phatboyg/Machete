namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class LINMap : X12SegmentMap<LIN, X12Entity>
    {
        public LINMap()
        {
            Id = "LIN";
            Name = "Drug Information";
            Value(x => x.Qualifier, 2, x => x.FixedLength(2).IsRequired());
            // TODO qualifier 2
            Value(x => x.NationalDrugCode, 3, x => x.MinLength(1).MaxLength(48).IsRequired());
        }
    }
}