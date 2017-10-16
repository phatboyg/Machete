namespace Machete.X12.Slices
{
    using Machete.Slices;


    public class X12SubElementSlice :
        SubTextSlice,
        IX12Slice
    {
        public X12SubElementSlice(ParseText text, TextSpan span)
            : base(text, span)
        {
        }
    }
}