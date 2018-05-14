namespace Machete
{
    using System.Collections.Generic;


    public static class LayoutListExtensions
    {
        /// <summary>
        /// Converts a LayoutList into an IEnumerable<Layout<TLayout>>.
        /// </summary>
        /// <param name="layouts"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Layout<TLayout>> ToEnumerable<TLayout>(this LayoutList<TLayout> layouts)
            where TLayout : Layout
        {
            for (int i = 0;; i++)
            {
                if (!layouts.TryGetValue(i, out var layout))
                    break;

                if (layout.HasValue)
                    yield return layout;
            }
        }
    }
}