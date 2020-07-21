namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2000A_837I :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        Segment<CUR> ForeignCurrencyInformation { get; }
        
        Layout<Loop2010AA_837I> Loop2010AA { get; }
        
        Layout<Loop2010AB_837I> Loop2010AB { get; }
        
        Layout<Loop2010AC_837I> Loop2010AC { get; }
    }
}