namespace Machete.Texts
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;


    /// <summary>
    /// Uses a <see cref="TextReader"/> to read text
    /// </summary>
    public class TextReaderStreamTextReader :
        IStreamTextReader,
        IDisposable
    {
        readonly TextReader _reader;
        readonly StringText _separator;
        readonly bool _disposeReader;

        Task<StreamText> _textSpan;
        bool _textSpanComputed;

        public TextReaderStreamTextReader(TextReader reader, string separator = null)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            _reader = reader;
            _disposeReader = true;

            if (separator != null)
                _separator = new StringText(separator);
        }

        TextReaderStreamTextReader(TextReader reader, StringText separator)
        {
            Debug.Assert(reader != null);
            Debug.Assert(separator != null);

            _reader = reader;
            _separator = separator;
        }

        async Task<StreamText> IStreamTextReader.Next(ParseText left)
        {
            var textSpan = await Text.ConfigureAwait(false);

            var parseTexts = _separator != null
                ? new[] {left, _separator, textSpan}
                : new[] {left, textSpan};
            var compositeText = new CompositeText(parseTexts);

            return new StreamText(compositeText, textSpan.Reader);
        }

        void IDisposable.Dispose()
        {
            if (_disposeReader)
                _reader.Dispose();
        }

        public Task<StreamText> Text
        {
            get
            {
                if (_textSpanComputed)
                    return _textSpan;

                _textSpan = GetTextSpan();
                _textSpanComputed = true;

                return _textSpan;
            }
        }

        async Task<StreamText> GetTextSpan()
        {
            string line = await _reader.ReadLineAsync().ConfigureAwait(false);
            if (line == null)
                return new StreamText(new EmptyText(), null);

            var next = new TextReaderStreamTextReader(_reader, _separator);

            return new StreamText(new StringText(line), next);
        }
    }
}