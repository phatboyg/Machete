namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class UMMap :
        X12SegmentMap<UM, X12Entity>
    {
        public UMMap()
        {
            Id = "UM";
            Name = "Health Care Services Review Information";

            Value(x => x.RequestCategoryCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.CertificateTypeCode, 2, x => x.FixedLength(1));
            Value(x => x.ServiceTypeCode, 3, x => x.MinLength(1).MaxLength(2));
            Entity(x => x.HealthCareServiceLocationInformation, 4);
        }
    }
}