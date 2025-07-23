
namespace Sortable;

public interface ISortable<T>
{
    T[] AscendingSort(T[] values);
    T[] DescendingSort(T[] values);
}
