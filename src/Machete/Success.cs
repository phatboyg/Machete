namespace Machete
{
    public struct Success<TInput, TResult> :
        Result<TInput, TResult>
    {
        public Success(TResult result, TInput next)
        {
            Result = result;
            Next = next;
        }

        public bool HasResult => true;
        public TResult Result { get; }
        public TInput Next { get; }
    }
}