namespace Machete.Texts
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// Uses a <see cref="TextReader"/> to read text
    /// </summary>
    public class StreamTextReader :
        IStreamTextReader,
        IDisposable
    {
        readonly Stream _stream;
        readonly bool _streamNeedsDisposed;
        readonly StreamReader _streamReader;

        Task<StreamText> _textSpan;
        bool _textSpanComputed;

        public StreamTextReader(Stream stream)
        {
            _stream = stream ?? throw new ArgumentNullException(nameof(stream));

            _streamReader = new StreamReader(stream, Encoding.UTF8);
            _streamNeedsDisposed = true;
        }

        StreamTextReader(Stream stream, StreamReader streamReader)
        {
            Debug.Assert(stream != null);

            _stream = stream;
            _streamReader = streamReader;
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
            if (_streamNeedsDisposed)
            {
                _streamReader.Dispose();
                _stream.Dispose();
            }
        }

        async Task<StreamText> IStreamTextReader.Next(ParseText left)
        {
            var textSpan = await Text.ConfigureAwait(false);

            var compositeText = new CompositeText(new[] {left, textSpan});

            return new StreamText(compositeText, textSpan.Reader);
        }

        async Task<StreamText> GetTextSpan()
        {
            var text = new char[4096];

            var textLength = await _streamReader.ReadAsync(text, 0, text.Length).ConfigureAwait(false);
            if (textLength == 0)
                return new StreamText(ParseText.Empty, null);

            var next = new StreamTextReader(_stream, _streamReader);

            return new StreamText(new StringText(new string(text, 0, textLength)), next);
        }
    }
}