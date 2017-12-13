﻿namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class DateTimeOffsetValueConverter :
        IValueConverter<DateTimeOffset>
    {
        readonly string[] _patterns;

        public DateTimeOffsetValueConverter(params string[] patterns)
        {
            _patterns = patterns;

            Styles = DateTimeStyles.AssumeUniversal | DateTimeStyles.AllowInnerWhite;
        }

        public DateTimeStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<DateTimeOffset> convertedValue)
        {
            Debug.Assert(slice != null);

            if (DateTimeOffset.TryParseExact(slice.Text.ToString(), _patterns, CultureInfo.InvariantCulture, Styles, out var value))
            {
                convertedValue = new ConvertedValue<DateTimeOffset>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = Value.Invalid<DateTimeOffset>(slice);
            return false;
        }
    }
}