namespace Machete
{
    public interface ListTextSlice
    {
        /// <summary>
        /// Returns the list text slice provider, for cases where a single slice contains multiple slices
        /// </summary>
        /// <param name="slice"></param>
        /// <returns></returns>
        bool TryGetListSlice(out TextSlice slice);
    }
}