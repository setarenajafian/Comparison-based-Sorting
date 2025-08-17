using System;
using MergeSort;
using BubbleSort;
using SelectionSort;
using InsertionSort;
using Sortable;
namespace SortingProgram;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your numbers ( separated by commas like 2,85,100,4) :");
        string input = Console.ReadLine();

        string[] inputNumbers = input.Split(',');
        int[] values = Array.ConvertAll(inputNumbers, int.Parse);

        // Select the sorting implementation
        ISortable<int> sorter;

        
        //sorter = new MergeSort<int>();
        sorter = new BubbleSort<int>();
        // sorter = new SelectionSort<int>();
        // sorter = new InsertionSort<int>();


        int[] ascendingSorted = sorter.AscendingSort(values);
        int[] descendingSorted = sorter.DescendingSort(values);


        Console.WriteLine("\nSorted Array (Ascending): " + string.Join(", ", ascendingSorted));
        Console.WriteLine("\nSorted Array (Descending): " + string.Join(", ", descendingSorted));
    }
}









































