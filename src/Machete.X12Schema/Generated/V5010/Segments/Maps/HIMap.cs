namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class HIMap :
        X12SegmentMap<HI, X12Entity>
    {
        public HIMap()
        {
            Id = "HI";
            Name = "Health Care Information Codes";
            
            Entity(x => x.HealthCareCodeInformation1, 1, x => x.FixedLength(1).IsRequired());
            Entity(x => x.HealthCareCodeInformation2, 2, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation3, 3, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation4, 4, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation5, 5, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation6, 6, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation7, 7, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation8, 8, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation9, 9, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation10, 10, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation11, 11, x => x.FixedLength(1));
            Entity(x => x.HealthCareCodeInformation12, 12, x => x.FixedLength(1));
        }
    }
}