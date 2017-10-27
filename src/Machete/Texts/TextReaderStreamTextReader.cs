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
        readonly bool _disposeReader;
        readonly TextReader _reader;
        readonly StringText _separator;

        Task<StreamText> _textSpan;
        bool _textSpanComputed;

        public TextReaderStreamTextReader(TextReader reader, string separator = null)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));

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

        void IDisposable.Dispose()
        {
            if (_disposeReader)
                _reader.Dispose();
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

        async Task<StreamText> GetTextSpan()
        {
            var line = await _reader.ReadLineAsync().ConfigureAwait(false);
            if (line == null)
                return new StreamText(ParseText.Empty, null);

            var next = new TextReaderStreamTextReader(_reader, _separator);

            return new StreamText(new StringText(line), next);
        }
    }
}