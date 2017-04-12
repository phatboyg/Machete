namespace Machete
{
    using System;


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


    public struct Unmatched<TInput, TResult> :
        Result<TInput, TResult>
    {
        public Unmatched(TInput next)
        {
            Next = next;
        }

        public bool HasValue => false;

        public TResult Value
        {
            get { throw new InvalidOperationException("There is not value, dork"); }
        }

        public TInput Next { get; }
    }
}