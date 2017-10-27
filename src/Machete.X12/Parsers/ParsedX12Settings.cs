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

        public ITextParser ElementParser => _elementParser.Value;
        public ITextParser SubElementParser => _subElementParser.Value;
        public ITextParser SegmentParser => _segmentParser.Value;
        public ITextParser RepetitionParser => _repetitionParser.Value;
        public ITextParser TextParser => _textParser.Value;

        readonly Lazy<ITextParser> _elementParser;
        readonly Lazy<ITextParser> _subElementParser;
        readonly Lazy<ITextParser> _segmentParser;
        readonly Lazy<ITextParser> _repetitionParser;
        readonly Lazy<ITextParser> _textParser;

        public ParsedX12Settings()
        {
            _elementParser = new Lazy<ITextParser>(() => new SeparatorParser(ElementSeparator));
            _subElementParser = new Lazy<ITextParser>(() => new SeparatorParser(SubElementSeparator));
            _segmentParser = new Lazy<ITextParser>(() => new SeparatorParser(SegmentSeparator));
            _repetitionParser = new Lazy<ITextParser>(() => new SeparatorParser(RepetitionSeparator));
            _textParser = new Lazy<ITextParser>(() => new X12TextParser(this));
        }
    }
}