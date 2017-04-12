namespace Machete.HL7.Slices
{
    using Machete.Slices;


    public class HL7SubComponentSlice :
        SubTextSlice,
        IHL7Slice
    {
        public HL7SubComponentSlice(ParseText text, TextSpan span)
            : base(text, span)
        {
        }
    }
}