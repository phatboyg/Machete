namespace Machete.X12Schema.V5010.Segments.Maps
{
    using Machete.X12;
    using Machete.X12.Configuration;

    public class HIMap : X12SegmentMap<HI, X12Entity>
    {
        public HIMap()
        {
            Id = "HI";
            Name = "Health Care Information Codes";
            Value(x => x.HealthCareCodeInformation, 1, x => x.MinLength(1).IsRequired());
            Value(x => x.HealthCareCodeInformation2, 2, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation3, 3, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation4, 4, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation5, 5, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation6, 6, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation7, 7, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation8, 8, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation9, 9, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation10, 10, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation11, 11, x => x.MinLength(1));
            Value(x => x.HealthCareCodeInformation12, 12, x => x.MinLength(1));
        }
    }
}