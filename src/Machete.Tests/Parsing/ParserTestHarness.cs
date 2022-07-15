namespace Machete.Tests.Parsing
{
    using System;


    public class ParserTestHarness
    {
        protected ReadOnlyMemory<string> SliceText(string message)
        {
            return message.Split("\r\n".ToCharArray());
        }
    }
}