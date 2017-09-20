namespace Machete.TextParsers
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
            if (span.Length == 0)
                return new Unmatched<TextSpan, TextSpan>(span);

            Match match = text.Match(_regex, span);
            if (match.Success && match.Index == 0)
                return new Success<TextSpan, TextSpan>(span.Take(match.Length), span.Skip(match.Length));

            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}