using Sortable;

namespace SelectionSort;

public class SelectionSort<T> : ISortable<T> where T : IComparable<T>
{
    public T[] AscendingSort(T[] values)
    {
        return SelectionSortAlgorithm(values, true);
    }

    public T[] DescendingSort(T[] values)
    {
        return SelectionSortAlgorithm(values, false);
    }

    private T[] SelectionSortAlgorithm(T[] values, bool ascending)
    {
        T[] result = (T[])values.Clone();
        int n = result.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int selectedIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if ((ascending && result[j].CompareTo(result[selectedIndex]) < 0) ||
                    (!ascending && result[j].CompareTo(result[selectedIndex]) > 0))
                {
                    selectedIndex = j;
                }
            }

            (result[i], result[selectedIndex]) = (result[selectedIndex], result[i]);
        }

        return result;
    }
}
