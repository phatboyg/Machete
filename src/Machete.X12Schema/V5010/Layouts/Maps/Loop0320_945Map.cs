namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0320_945Map :
        X12LayoutMap<Loop0320_945, X12Entity>
    {
        public Loop0320_945Map()
        {
            Id = "Loop_0320_945";
            Name = "Loop 0320";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.MarksAndNumbersInformation, 1);
            Segment(x => x.PalletTypeAndLoadCharacteristics, 2);
            Segment(x => x.ExtendedReferenceInformation, 3);
        }
    }
}