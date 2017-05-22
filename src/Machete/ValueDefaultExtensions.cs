namespace Machete
{
    using System;

    
    public static class ValueDefaultExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static TValue ValueOrDefault<TValue>(this Value<TValue> value)
        {
            if (value == null || !value.HasValue)
                return default(TValue);

            return value.Value;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static TValue ValueOrDefault<TValue>(this Value<TValue> value, TValue defaultValue)
        {
            if (value == null || !value.HasValue)
                return default(TValue);

            return value.HasValue ? value.Value : defaultValue;
        }
    }
}