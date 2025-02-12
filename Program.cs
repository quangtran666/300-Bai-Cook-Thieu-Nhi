var arr = new int[] { 64, 25, 12, 22, 11 };

SelectionSort(arr);

Console.WriteLine(string.Join(", ",  arr));

void SelectionSort(int[] arr)
{
    for (var i = 0; i < arr.Length; i++)
    { 
        var min = arr[i];
        var minIndex = i;
        for (var j = i; j < arr.Length; j++)
        {
            if (arr[j] < min)
            {
                min = arr[j];
                minIndex = j;
            }
        }
        (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
    }
}