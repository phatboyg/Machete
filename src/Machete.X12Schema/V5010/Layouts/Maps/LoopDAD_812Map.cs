namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopDAD_812Map :
        X12LayoutMap<LoopDAD_812, X12Entity>
    {
        public LoopDAD_812Map()
        {
            Id = "Loop_DAD_812";
            Name = "Loop DAD 812";
            
            Segment(x => x.DebitAuthorizationDetail, 0);
            Segment(x => x.IndividualOrOrganizationName, 1);
            Segment(x => x.AdditionalNameInformation, 2);
            Segment(x => x.AddressInformation, 3);
            Segment(x => x.GeographicInformation, 4);
            Segment(x => x.ReferenceInformation, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
        }
    }
}