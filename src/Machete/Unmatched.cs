namespace Machete
{
    using System;


    public struct Unmatched<TInput, TResult> :
        Result<TInput, TResult>
    {
        public Unmatched(TInput next)
        {
            Next = next;
        }

        public bool HasResult => false;
        public TResult Result => throw new InvalidOperationException("The result is unmatched, and there is no result");
        public TInput Next { get; }
    }
}