using Sortable;

namespace MergeSort;

public class MergeSort<T> : ISortable<T> where T : IComparable<T>
{
    public T[] AscendingSort(T[] values)
    {
        return MergeSortAlgorithm(values, true);
    }

    public T[] DescendingSort(T[] values)
    {
        return MergeSortAlgorithm(values, false);
    }

    private T[] MergeSortAlgorithm(T[] values, bool ascending)
    {
        if (values.Length <= 1)
            return values;

        int mid = values.Length / 2;
        T[] left = values.Take(mid).ToArray();
        T[] right = values.Skip(mid).ToArray();

        left = MergeSortAlgorithm(left, ascending);
        right = MergeSortAlgorithm(right, ascending);

        return Merge(left, right, ascending);
    }

    private T[] Merge(T[] left, T[] right, bool ascending)
    {
        List<T> result = new();
        int i = 0, j = 0;

        while (i < left.Length && j < right.Length)
        {
            if ((ascending && left[i].CompareTo(right[j]) <= 0) || (!ascending && left[i].CompareTo(right[j]) >= 0))
            {
                result.Add(left[i]);
                i++;
            }
            else
            {
                result.Add(right[j]);
                j++;
            }
        }

        result.AddRange(left.Skip(i));
        result.AddRange(right.Skip(j));

        return result.ToArray();
    }
}
