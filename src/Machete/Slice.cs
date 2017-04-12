namespace Machete
{
    using Slices;


    public static class Slice
    {
        /// <summary>
        /// An empty fragment has nothing inside of it, and only returns itself
        /// </summary>
        public static readonly TextSlice Empty = new EmptySlice();

        /// <summary>
        /// A missing fragment, which throws an exception if access is attempted
        /// </summary>
        public static readonly TextSlice Missing = new MissingSlice();
    }
}