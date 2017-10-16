namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class MOAMap : X12SegmentMap<MOA, X12Entity>
    {
        public MOAMap()
        {
            Id = "MOA";
            Name = "Medicare Outpatient Adjudication";
            Value(x => x.ReimbursementRate, 1, x => x.MinLength(1));
            Value(x => x.HcpcsPayable, 2, x => x.MinLength(1));
            Value(x => x.RemarkCode1, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RemarkCode2, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RemarkCode3, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RemarkCode4, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.RemarkCode5, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.EsrdPayment, 8, x => x.MinLength(1));
            Value(x => x.NonpayableProfessionalComponent, 9, x => x.MinLength(1));
        }
    }
}