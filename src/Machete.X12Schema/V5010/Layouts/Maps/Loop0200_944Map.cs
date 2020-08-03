namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0200_944Map :
        X12LayoutMap<Loop0200_944, X12Entity>
    {
        public Loop0200_944Map()
        {
            Id = "Loop_0200_944";
            Name = "Loop 0200";

            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.PalletTypeAndLoadCharacteristics, 2);
            Segment(x => x.AdministrativeCommunicationsContact, 3);
            Layout(x => x.Loop210, 4);
        }
    }
}