namespace MacheteToo;

public readonly ref struct Cursor<T>
{
    readonly ReadOnlySpan<T> _span;
    readonly int _index;

    public Cursor(ReadOnlySpan<T> span)
    {
        _span = span;
        _index = -1;

        Current = default;
    }

    Cursor(ReadOnlySpan<T> span, int index)
    {
        _span = span;
        _index = index;

        Current = span[index];
    }

    public readonly T? Current;

    public bool TryGetNext(out Cursor<T> next)
    {
        var nextIndex = _index + 1;

        if (nextIndex < _span.Length)
        {
            next = new Cursor<T>(_span, nextIndex);
            return true;
        }

        next = default;
        return false;
    }

    public bool Equals(Cursor<T> other)
    {
        return other._span == _span && other._index == _index;
    }
}