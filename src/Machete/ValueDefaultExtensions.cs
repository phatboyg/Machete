namespace Machete
{
    public static class ValueDefaultExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue ValueOrDefault<TValue>(this Value<TValue> value)
        {
            return value != null && value.HasValue ? value.Value : default(TValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue ValueOrDefault<TValue>(this Value<TValue> value, TValue defaultValue)
        {
            return value != null && value.HasValue ? value.Value : defaultValue;
        }
    }
}