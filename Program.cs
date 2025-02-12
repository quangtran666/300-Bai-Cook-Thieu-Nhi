var arr = new int[] { 5, 2, 4, 6, 1, 3 };

IntertionSort(arr);

Console.WriteLine(string.Join(", ", arr));

void IntertionSort(int[] arr)
{
    for (var i = 1; i < arr.Length; i++)
    {
        var temp = arr[i];
        var j = i - 1;

        while (j >= 0 && arr[j] > temp)
        {
            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            j--;
        } 
    }
}