namespace Machete.Internals.Mapping
{
    using System;


    public static class ValueObject
    {
        public static bool IsValueObjectType(Type valueType)
        {
            if (valueType.IsValueType
                || valueType == typeof(string)
                || valueType == typeof(Uri)
                || valueType == typeof(Version)
                || typeof(Exception).IsAssignableFrom(valueType))
                return true;

            return false;
        }
    }
}