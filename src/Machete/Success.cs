namespace Machete
{
    public struct Success<TInput, TResult> :
        Result<TInput, TResult>
    {
        public Success(TResult value, TInput next)
        {
            Value = value;
            Next = next;
        }

        public bool HasValue => true;
        public TResult Value { get; }
        public TInput Next { get; }
    }
}