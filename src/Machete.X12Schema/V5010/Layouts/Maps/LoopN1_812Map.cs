namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN1_812Map :
        X12LayoutMap<LoopN1_1_812, X12Entity>
    {
        public LoopN1_812Map()
        {
            Id = "Loop_N1_812";
            Name = "Loop N1";
            
            Segment(x => x.Name, 0);
            Segment(x => x.AdditionalNameInformation, 1);
            Segment(x => x.AddressInformation, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.ReferenceInformation, 5);
            Segment(x => x.AdministrativeCommunicationsContact, 6);
            Layout(x => x.LoopLM, 7);
            Layout(x => x.LoopN11, 8);
        }
    }
}