using Sortable;

namespace InsertionSort;

public class InsertionSort<T> : ISortable<T> where T : IComparable<T>
{
    public T[] AscendingSort(T[] values)
    {
        return InsertionSortAlgorithm(values, true);
    }

    public T[] DescendingSort(T[] values)
    {
        return InsertionSortAlgorithm(values, false);
    }

    private T[] InsertionSortAlgorithm(T[] values, bool ascending)
    {
        T[] result = (T[])values.Clone();

        for (int i = 1; i < result.Length; i++)
        {
            T key = result[i];
            int j = i - 1;

            while (j >= 0 && ((ascending && result[j].CompareTo(key) > 0) ||
                              (!ascending && result[j].CompareTo(key) < 0)))
            {
                result[j + 1] = result[j];
                j--;
            }

            result[j + 1] = key;
        }

        return result;
    }
}

