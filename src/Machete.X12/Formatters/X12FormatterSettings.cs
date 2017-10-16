namespace Machete.X12.Formatters
{
    public class X12FormatterSettings :
        X12Settings
    {
        public X12FormatterSettings()
        {
            ElementSeparator = '|';
            SubElementSeparator = '^';
            RepetitionSeparator = '~';
            SegmentSeparator = '~';
        }

        public char ElementSeparator { get; }
        public char SubElementSeparator { get; }
        public char RepetitionSeparator { get; }
        public char SegmentSeparator { get; }
    }
}