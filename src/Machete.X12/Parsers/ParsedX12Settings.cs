namespace Machete.X12.Parsers
{
    using System;
    using TextParsers;


    public class ParsedX12Settings :
        X12ParserSettings
    {
        public char ElementSeparator { get; set; }
        public char SubElementSeparator { get; set; }
        public char SegmentSeparator { get; set; }
        public char RepetitionSeparator { get; set; }

        public TextParser ElementParser => _elementParser.Value;
        public TextParser SubElementParser => _subElementParser.Value;
        public TextParser SegmentParser => _segmentParser.Value;
        public TextParser RepetitionParser => _repetitionParser.Value;
        public TextParser TextParser => _textParser.Value;

        readonly Lazy<TextParser> _elementParser;
        readonly Lazy<TextParser> _subElementParser;
        readonly Lazy<TextParser> _segmentParser;
        readonly Lazy<TextParser> _repetitionParser;
        readonly Lazy<TextParser> _textParser;

        public ParsedX12Settings()
        {
            _elementParser = new Lazy<TextParser>(() => new SeparatorParser(ElementSeparator));
            _subElementParser = new Lazy<TextParser>(() => new SeparatorParser(SubElementSeparator));
            _segmentParser = new Lazy<TextParser>(() => new SeparatorParser(SegmentSeparator));
            _repetitionParser = new Lazy<TextParser>(() => new SeparatorParser(RepetitionSeparator));
            _textParser = new Lazy<TextParser>(() => new X12TextParser(this));
        }
    }
}