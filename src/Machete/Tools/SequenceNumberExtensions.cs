namespace Machete
{
    using Tools;


    public static class SequenceNumberExtensions
    {
        public static int NextSequenceNumber<T1>(this IContext context)
        {
            return context.GetOrAddContext(() => new SequenceNumber()).Of<T1>().Next();
        }

        public static int NextSequenceNumber<T1, T2>(this IContext context)
        {
            return context.GetOrAddContext(() => new SequenceNumber()).Of<T1>().Of<T2>().Next();
        }

        public static int CurrentSequenceNumber<T1>(this IContext context)
        {
            return context.GetOrAddContext(() => new SequenceNumber()).Of<T1>().Current;
        }

        public static int CurrentSequenceNumber<T1, T2>(this IContext context)
        {
            return context.GetOrAddContext(() => new SequenceNumber()).Of<T1>().Of<T2>().Current;
        }
    }
}