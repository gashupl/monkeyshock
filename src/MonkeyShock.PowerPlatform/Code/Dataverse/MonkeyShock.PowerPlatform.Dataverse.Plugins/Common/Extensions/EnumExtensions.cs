namespace System
{
    public static class EnumExtensions
    {
        public static T CastToEnum<T>(this int value) where T : struct, IComparable, IFormattable, IConvertible
        {
            return (T)Enum.ToObject(typeof(T), value);
        }
    }
}
