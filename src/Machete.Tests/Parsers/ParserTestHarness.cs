namespace Machete.Tests.Parsers
{
    using System;
    using System.Collections.Generic;


    public class ParserTestHarness
    {
        protected IReadOnlyList<string> SliceText(string message)
        {
            return Array.AsReadOnly(message.Split("\r\n".ToCharArray()));
        }
    }
}