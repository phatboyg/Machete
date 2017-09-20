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

        public TResult Result
        {
            get { throw new InvalidOperationException("There is not value, dork"); }
        }

        public TInput Next { get; }
    }
}