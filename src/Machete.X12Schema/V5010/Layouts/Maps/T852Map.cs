namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T852Map :
        X12LayoutMap<T852, X12Entity>
    {
        public T852Map()
        {
            Id = "T852";
            Name = "852 Product Activity Data";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.ReportingDateOrAction, 2);
            Segment(x => x.PreassignedPurchaseOrderNumbers, 3);
            Segment(x => x.ExtendedReferenceInformation, 4);
            Segment(x => x.AdministrativeCommunicationsContact, 5);
            Layout(x => x.LoopN1, 6);
            Layout(x => x.LoopLIN, 7);
            Segment(x => x.TransactionTotals, 8);
            Segment(x => x.TransactionSetTrailer, 9);
            Segment(x => x.FunctionalGroupTrailer, 10);
        }
    }
}