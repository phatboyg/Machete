namespace Machete.Slices
{
    using System;


    public abstract class BaseEntitySlice :
        TextSlice
    {
        TextSlice[] _slices;
        bool _slicesComputed;

        protected BaseEntitySlice(ParseText text)
        {
            Text = text;
        }

        public ParseText Text { get; }

        public TextSpan SourceSpan => new TextSpan(0, Text.Length);

        public ParseText SourceText => throw new InvalidOperationException();

        public bool TryGetSlice(int index, out TextSlice slice)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Must be >= 0");

            if (!_slicesComputed)
            {
                _slices = GetSlices();
                _slicesComputed = true;
            }

            if (index < _slices.Length)
            {
                slice = _slices[index];
                return true;
            }

            slice = default(TextSlice);
            return false;
        }

        protected abstract TextSlice[] GetSlices();
    }
}