namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M943Map :
        X12LayoutMap<M943, X12Entity>
    {
        public M943Map()
        {
            Id = "M943";
            Name = "943 Warehouse Stock Transfer Shipment Advice";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}