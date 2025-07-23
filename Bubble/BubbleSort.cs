using Sortable;

namespace BubbleSort;

public class BubbleSort<T> : ISortable<T> where T : IComparable<T>
{
    public T[] AscendingSort(T[] values)
    {
        return BubbleSortAlgorithm(values, true);
    }

    public T[] DescendingSort(T[] values)
    {
        return BubbleSortAlgorithm(values, false);
    }

    private T[] BubbleSortAlgorithm(T[] values, bool ascending)
    {
        T[] result = (T[])values.Clone();
        int n = result.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((ascending && result[j].CompareTo(result[j + 1]) > 0) ||
                    (!ascending && result[j].CompareTo(result[j + 1]) < 0))
                {
                    (result[j], result[j + 1]) = (result[j + 1], result[j]);
                }
            }
        }

        return result;
    }
}
