using MergeSort;
using System.Security.Cryptography.X509Certificates;

var mergeSort = new sortMerge();
int[] input = new int[] { 1, 5, 6, 8, 9, 2 };
int[] sorted = new int[] { 0 };
sorted = mergeSort.Sort(input);
Console.Write("Unsorted array: ");
input.ToList().ForEach(item => Console.Write($"{item} "));
Console.WriteLine();
Console.Write("Sorted array: ");
sorted.ToList().ForEach(item => Console.Write($"{item} "));

