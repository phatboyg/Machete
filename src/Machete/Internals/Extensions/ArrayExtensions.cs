namespace Machete.Internals.Extensions
{
    static class ArrayExtensions
    {
        // same as Array.BinarySearch, but without using IComparer to compare ints
        internal static int BinarySearch(this int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                var middle = low + ((high - low) >> 1);
                var midValue = array[middle];

                if (midValue == value)
                    return middle;

                if (midValue > value)
                    high = middle - 1;
                else
                    low = middle + 1;
            }

            return ~low;
        }
    }
}