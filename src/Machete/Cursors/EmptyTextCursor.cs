namespace Machete.Cursors
{
    using System;
    using System.Threading.Tasks;
    using Texts;


    public class EmptyTextCursor :
        TextCursor
    {
        public EmptyTextCursor(StreamText text, TextSpan span)
        {
            InputText = text;
            NextSpan = span;
        }

        public bool HasCurrent => false;
        public bool HasNext => false;

        public ParseText Current => ParseText.Empty;
        public TextSpan CurrentSpan => TextSpan.Empty;

        Task<TextCursor> TextCursor.Next()
        {
            throw new InvalidOperationException("Next is not valid, the cursor is empty");
        }

        public StreamText InputText { get; }
        public TextSpan NextSpan { get; }
    }
}