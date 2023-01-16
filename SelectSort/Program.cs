using SelectSort;


var selectSort = new SortSelect() { input = new int[] { 742, 231, 182, 793, 759, 136, 725, 708, 124, 674, 657, 691, 623, 572, 538, 504, 470, 453, 436, 419, 402, 385, 368, 350, 333, 316, 299, 282, 265, 248, 215, 198, 167, 151, 136, 113, 100, 89, 73, 61, 49, 32, 16, 1 } };
Console.Write("Unsorted array: ");
selectSort.input.ToList().ForEach(item => Console.Write($"{item} "));
selectSort.Run();
Console.WriteLine();
Console.Write("Sorted array: ");
selectSort.input.ToList().ForEach(item => Console.Write($"{item} "));
