namespace Machete.Cursors
{
    using System;
    using System.Threading.Tasks;
    using Texts;


    public class EmptyTextCursor :
        TextCursor
    {
        readonly StreamText _sourceText;
        readonly TextSpan _remainingSpan;

        public EmptyTextCursor(StreamText text, TextSpan span)
        {
            _sourceText = text;
            _remainingSpan = span;
        }

        public bool HasCurrent => false;
        public bool HasNext => false;

        public ParseText Current => ParseText.Empty;
        public TextSpan CurrentSpan => TextSpan.Empty;

        Task<TextCursor> TextCursor.Next()
        {
            throw new InvalidOperationException("Next is not valid, the cursor is empty");
        }

        StreamText TextCursor.InputText => _sourceText;
        TextSpan TextCursor.NextSpan => _remainingSpan;
    }
}