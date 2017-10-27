namespace Machete.Texts
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;


    /// <summary>
    /// Uses a <see cref="TextReader"/> to read text
    /// </summary>
    public class StringStreamTextReader :
        IStreamTextReader,
        IDisposable
    {
        readonly int _index;
        readonly StringText _separator;
        readonly string[] _strings;

        Task<StreamText> _textSpan;
        bool _textSpanComputed;

        public StringStreamTextReader(IEnumerable<string> strings, string separator = null)
        {
            _strings = strings.ToArray();
            _index = 0;

            if (separator != null)
                _separator = new StringText(separator);
        }

        public StringStreamTextReader(string[] strings, int index, StringText separator)
        {
            _strings = strings;
            _index = index;
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
            if (_index >= _strings.Length)
                return new StreamText(ParseText.Empty, null);

            var next = new StringStreamTextReader(_strings, _index + 1, _separator);

            return new StreamText(new StringText(_strings[_index]), next);
        }
    }
}