namespace Machete
{
    using System;
    using System.Threading.Tasks;


    public static class TaskSelectManyExtensions
    {
        public static async Task<TResult> SelectMany<TInput, T, TResult>(this Task<TInput> task, Func<TInput, Task<T>> function, Func<TInput, T, TResult> projection)
        {
            TInput a = await task.ConfigureAwait(false);
            T b = await function(a).ConfigureAwait(false);

            return projection(a, b);
        }

        public static async Task<TResult> SelectMany<TInput, T, TResult>(this Task<TInput> task, Func<TInput, Task<T>> function, Func<TInput, T, Task<TResult>> projection)
        {
            TInput a = await task.ConfigureAwait(false);
            T b = await function(a).ConfigureAwait(false);

            return await projection(a, b).ConfigureAwait(false);
        }
    }
}