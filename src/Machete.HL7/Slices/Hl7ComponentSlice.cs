namespace Machete.HL7.Slices
{
    public class HL7ComponentSlice :
        HL7Slice<HL7SubComponentSlice>
    {
        public HL7ComponentSlice(HL7ParserSettings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.SubComponentParser)
        {
        }

        protected override HL7SubComponentSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new HL7SubComponentSlice(text, span);
        }
    }
}