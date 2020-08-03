namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0310_945Map :
        X12LayoutMap<Loop0310_945, X12Entity>
    {
        public Loop0310_945Map()
        {
            Id = "Loop_0310_945";
            Name = "Loop 0310";
            
            Segment(x => x.WarehouseItemDetail, 0);
            Segment(x => x.LineITemDetailDescription, 1);
            Segment(x => x.ExtendedReferenceInformation, 2);
            Segment(x => x.DateOrTime, 3);
            Segment(x => x.QuantityInformation, 4);
            Segment(x => x.Measurements, 5);
            Segment(x => x.MonetaryAmountInformation, 6);
            Segment(x => x.PortOrTerminal, 7);
            Segment(x => x.CarrierDetailsWarehouse, 8);
            Layout(x => x.Loop0320, 9);
            Segment(x => x.AllowanceOrCharge, 10);
            Layout(x => x.Loop0330, 11);
            Segment(x => x.LoopHeader, 12);
            Layout(x => x.Loop0340, 13);
            Segment(x => x.LoopTrailer, 14);
            Layout(x => x.Loop0360, 15);
        }
    }
}