namespace Machete.HL7.Parsers
{
    using System;
    using Machete.Parsers.TextParsers;


    public class ParsedHL7Settings :
        HL7ParserSettings
    {
        public char FieldSeparator { get; set; }
        public char ComponentSeparator { get; set; }
        public char RepetitionSeparator { get; set; }
        public char SubComponentSeparator { get; set; }
        public char EscapeCharacter { get; set; }

        public TextParser FieldParser => _fieldParser.Value;
        public TextParser ComponentParser => _componentParser.Value;
        public TextParser SubComponentParser => _subComponentParser.Value;
        public TextParser RepetitionParser => _repetitionParser.Value;
        public TextParser TextParser => _textParser.Value;

        readonly Lazy<TextParser> _fieldParser;
        readonly Lazy<TextParser> _componentParser;
        readonly Lazy<TextParser> _subComponentParser;
        readonly Lazy<TextParser> _repetitionParser;
        readonly Lazy<TextParser> _textParser;

        public ParsedHL7Settings()
        {
            _fieldParser = new Lazy<TextParser>(() => new SeparatorParser(FieldSeparator));
            _componentParser = new Lazy<TextParser>(() => new SeparatorParser(ComponentSeparator));
            _subComponentParser = new Lazy<TextParser>(() => new SeparatorParser(SubComponentSeparator));
            _repetitionParser = new Lazy<TextParser>(() => new SeparatorParser(RepetitionSeparator));
            _textParser = new Lazy<TextParser>(() => new HL7TextParser(this));
        }
    }
}