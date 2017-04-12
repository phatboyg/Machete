namespace Machete.HL7.Slices
{
    public class HL7RepeatingFieldSlice :
        HL7Slice<HL7FieldSlice>
    {
        public HL7RepeatingFieldSlice(HL7Settings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.RepetitionParser)
        {
        }

        protected override HL7FieldSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new HL7FieldSlice(Settings, text, span);
        }
    }
}