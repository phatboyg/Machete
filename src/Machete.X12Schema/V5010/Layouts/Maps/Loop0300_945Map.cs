namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0300_945Map :
        X12LayoutMap<Loop0300_945, X12Entity>
    {
        public Loop0300_945Map()
        {
            Id = "Loop_0300_945";
            Name = "Loop 0300";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.PalletTypeAndLoadCharacteristics, 2);
            Segment(x => x.ExtendedReferenceInformation, 3);
            Layout(x => x.Loop0310, 4);
        }
    }
}