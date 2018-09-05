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
            
            Entity(x => x.HealthCareCodeInformation1, 1, x => x.IsRequired());
            Entity(x => x.HealthCareCodeInformation2, 2);
            Entity(x => x.HealthCareCodeInformation3, 3);
            Entity(x => x.HealthCareCodeInformation4, 4);
            Entity(x => x.HealthCareCodeInformation5, 5);
            Entity(x => x.HealthCareCodeInformation6, 6);
            Entity(x => x.HealthCareCodeInformation7, 7);
            Entity(x => x.HealthCareCodeInformation8, 8);
            Entity(x => x.HealthCareCodeInformation9, 9);
            Entity(x => x.HealthCareCodeInformation10, 10);
            Entity(x => x.HealthCareCodeInformation11, 11);
            Entity(x => x.HealthCareCodeInformation12, 12);
        }
    }
}