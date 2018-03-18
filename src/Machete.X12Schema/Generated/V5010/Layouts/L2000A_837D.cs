namespace Machete.X12Schema.V5010.Layouts
{
    using X12;
    using X12.Schema.Segments;


    public interface L2000A_837D :
        X12Layout
    {
        Segment<HL> BillingProviderHeirarchicalLevel { get; }
        
        Segment<PRV> BillingProviderSpecialtyInformation { get; }
        
        Segment<CUR> ForeignCurrencyInformation { get; }
        
        Layout<L2010AA_837D> BillingProvider { get; }
        
        Layout<L2010AB_837D> PayToAddress { get; }
        
        Layout<L2010AC_837D> PayToPlan { get; }
    }
}