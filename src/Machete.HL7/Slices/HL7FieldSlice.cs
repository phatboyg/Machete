namespace Machete.HL7.Slices
{
    public class HL7FieldSlice :
        HL7Slice<HL7ComponentSlice>
//        ,
  //      ListTextFragment
    {
        TextSlice _listSlice;

        public HL7FieldSlice(HL7Settings settings, ParseText text, TextSpan span)
            : base(settings, text, span, settings.ComponentParser)
        {
        }

        protected override HL7ComponentSlice CreateSlice(ParseText text, TextSpan span)
        {
            return new HL7ComponentSlice(Settings, text, span);
        }

        public bool TryGetListSlice(out TextSlice slice)
        {
            slice = _listSlice ?? (_listSlice = new HL7RepeatingFieldSlice(Settings, SourceText, SourceSpan));
            return true;
        }
    }
}