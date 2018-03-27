namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000C_271Map :
        X12LayoutMap<L2000C_271, X12Entity>
    {
        public L2000C_271Map()
        {
            Id = "2000C";
            Name = "Subscriber Level";
            
            Segment(x => x.SubscriberLevel, 0);
            Segment(x => x.SubscriberTraceNumber, 1);
            Layout(x => x.Subscriber, 2);
            Layout(x => x.SubscriberEligibilityOrBenefitInformation, 3);
            Layout(x => x.SubscriberEligibilityOrBenefitAdditionalInformation, 4);
            Layout(x => x.SubscriberBenefitRelatedEntity, 5);
        }
    }
}