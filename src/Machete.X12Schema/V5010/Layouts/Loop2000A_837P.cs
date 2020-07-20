namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000A_837P :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        Segment<CUR> ForeignCurrencyInformation { get; }
        
        Layout<Loop2010AA_837P> Loop2010AA { get; }
        
        Layout<Loop2010AB_837P> Loop2010AB { get; }
        
        Layout<Loop2010AC_837P> Loop2010AC { get; }
    }
}