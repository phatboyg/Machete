namespace Machete
{
    public readonly ref struct ValueResult<TInput, TResult>
    {
        public readonly ValueCursor<TInput> Next;
        public readonly TResult Result;
        public readonly bool HasResult;

        public ValueResult(TResult result, ValueCursor<TInput> next)
        {
            Next = next;
            Result = result;

            HasResult = true;
        }

        public ValueResult(ValueCursor<TInput> next)
        {
            Next = next;
            Result = default;
            HasResult = false;
        }
    }
}