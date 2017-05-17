namespace Machete.Testing
{
    using System.Linq;

    public abstract class BaseMacheteTestContext
    {
        public virtual string NormalizeLineEndings(string content)
        {
            string normalizedText = content
                .Replace("\r\n", "\r")
                .Replace("\n", "\r")
                .Replace("\r\r", "\r")
                .Trim('\r', '\n');

            string finalText = string.Join("\r",
                normalizedText.Split('\r').Select(line => line.TrimEnd('|')).ToArray());

            return finalText;
        }
    }
}