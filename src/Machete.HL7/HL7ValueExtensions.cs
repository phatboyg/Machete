namespace Machete.HL7
{
    using System;


    public static class HL7ValueExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Segment{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, Segment<T>> getter)
            where TSegment : HL7Segment
            where T : HL7Segment
        {
            if (source == null || !source.HasValue)
                return Segment.Missing<T>();

            return getter(source.Value) ?? Segment.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Segment{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static Segment<TSegment> Select<TCursor, TLayout, TSegment>(this Result<Cursor<TCursor>, TLayout> source, Func<TLayout, Segment<TSegment>> getter)
            where TSegment : HL7Segment
        {
            if (source == null || !source.HasValue)
                return Segment.Missing<TSegment>();

            return getter(source.Value) ?? Segment.Missing<TSegment>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a <see cref="ValueList{TValue}"/> object given the specified index.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <param name="index"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static Value<TValue> Select<TValue, TSegment>(this TSegment source, Func<TSegment, ValueList<TValue>> getter, int index)
            where TSegment : HL7Segment
        {
            if (source == null || (source.IsEmpty.HasValue && source.IsEmpty.Value))
                return Value.Missing<TValue>();

            ValueList<TValue> valueList = getter(source);
            if (valueList == null || !valueList.HasValue || index < 0)
                return Value.Missing<TValue>();

            Value<TValue> value;
            return valueList.TryGetValue(index, out value) ? value : Value.Missing<TValue>();
        }

        /// <summary>
        /// Safely returns the <see cref="ValueList{TValue}"/> from a <see cref="TSegment"/> object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static ValueList<TValue> Select<TValue, TSegment>(this TSegment source, Func<TSegment, ValueList<TValue>> getter)
            where TSegment : HL7Segment
        {
            if (source == null || (source.IsEmpty.HasValue && source.IsEmpty.Value))
                return ValueList.Missing<TValue>();

            return getter(source) ?? ValueList.Missing<TValue>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a <see cref="TSegment"/> object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static Value<TValue> Select<TValue, TSegment>(this TSegment source, Func<TSegment, Value<TValue>> getter)
            where TSegment : HL7Segment
        {
            if (source == null || (source.IsEmpty.HasValue && source.IsEmpty.Value))
                return Value.Missing<TValue>();

            return getter(source) ?? Value.Missing<TValue>();
        }
    }
}