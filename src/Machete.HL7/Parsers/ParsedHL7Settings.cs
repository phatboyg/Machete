namespace Machete.HL7.Parsers
{
    using System;
    using TextParsers;


    public class ParsedHL7Settings :
        HL7ParserSettings
    {
        public char FieldSeparator { get; set; }
        public char ComponentSeparator { get; set; }
        public char RepetitionSeparator { get; set; }
        public char SubComponentSeparator { get; set; }
        public char EscapeCharacter { get; set; }

        public ITextParser FieldParser => _fieldParser.Value;
        public ITextParser ComponentParser => _componentParser.Value;
        public ITextParser SubComponentParser => _subComponentParser.Value;
        public ITextParser RepetitionParser => _repetitionParser.Value;
        public ITextParser TextParser => _textParser.Value;

        readonly Lazy<ITextParser> _fieldParser;
        readonly Lazy<ITextParser> _componentParser;
        readonly Lazy<ITextParser> _subComponentParser;
        readonly Lazy<ITextParser> _repetitionParser;
        readonly Lazy<ITextParser> _textParser;

        public ParsedHL7Settings()
        {
            _fieldParser = new Lazy<ITextParser>(() => new SeparatorParser(FieldSeparator));
            _componentParser = new Lazy<ITextParser>(() => new SeparatorParser(ComponentSeparator));
            _subComponentParser = new Lazy<ITextParser>(() => new SeparatorParser(SubComponentSeparator));
            _repetitionParser = new Lazy<ITextParser>(() => new SeparatorParser(RepetitionSeparator));
            _textParser = new Lazy<ITextParser>(() => new HL7TextParser(this));
        }
    }
}