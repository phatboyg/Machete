namespace Machete
{
    public static class ValueListExtensions
    {
        /// <summary>
        /// Returns a count of segments in <see cref="ValueList{TValue}"/>
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static int Count<TValue>(this ValueList<TValue> source)
        {
            if (source == null || !source.HasValue)
                return 0;

            Value<TValue> value;
            int i = 0;
            for (;; i++)
                if (!source.TryGetValue(i, out value))
                    break;

            return i;
        }
    }
}