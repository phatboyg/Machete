namespace Machete.Parsers.TextParsers
{
    using System.Text.RegularExpressions;


    public class RegExParser :
        TextParser
    {
        readonly Regex _regex;

        public RegExParser(string pattern, RegexOptions options = RegexOptions.None)
        {
            _regex = new Regex(pattern, options | RegexOptions.Compiled);
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if(span.Length == 0)
                return new Unmatched<TextSpan, TextSpan>(span);

            // TODO add this to the ParseText to avoid string copy
            Match match = _regex.Match(text.ToString(span));
            if(match.Success && match.Index == 0)
                return new Success<TextSpan, TextSpan>(new TextSpan(span.Start, match.Length), TextSpan.FromBounds(span.Start + match.Length, span.End));

            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}