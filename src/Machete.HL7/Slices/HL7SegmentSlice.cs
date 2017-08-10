namespace Machete.HL7.Slices
{
    public class HL7SegmentSlice :
        HL7Slice<HL7FieldSlice>
    {
        public HL7SegmentSlice(HL7ParserSettings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.FieldParser)
        {
        }

        protected override HL7FieldSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new HL7FieldSlice(Settings, text, span);
        }
    }
}