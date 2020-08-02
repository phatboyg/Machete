namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0310_940Map :
        X12LayoutMap<Loop0310_940, X12Entity>
    {
        public Loop0310_940Map()
        {
            Id = "Loop_0310_940";
            Name = "Loop 0310";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.DestinationQuantity, 2);
            Segment(x => x.PartyIdentification, 3);
            Segment(x => x.DateOrTime, 4);
            Segment(x => x.ExtendedReferenceInformation, 5);
            Layout(x => x.LoopN1, 6);
            Segment(x => x.HazardousClassificationInformation, 7);
            Segment(x => x.HazardousMaterialIdentifyingReferenceNumbers, 8);
            Segment(x => x.HazardousCertification, 9);
            Layout(x => x.Loop0320, 10);
            Segment(x => x.LoopHeader, 11);
            Layout(x => x.Loop0330, 12);
            Layout(x => x.Loop0340, 13);
        }
    }
}