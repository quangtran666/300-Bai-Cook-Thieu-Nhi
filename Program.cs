var arr = new int[] { 12, 11, 13, 5, 6, 7 };

MergeSort(arr);

Console.WriteLine(string.Join(", ", arr));

void MergeSort(int[] arr)
{
    var inputLength = arr.Length;
    
    if (inputLength < 2)
        return;
    
    var mid = inputLength / 2;
    var left = new int[mid];
    var right = new int[inputLength - mid];
    
    for (var i = 0; i < mid; i++)
        left[i] = arr[i];
    
    for (var i = mid; i < inputLength; i++)
        right[i - mid] = arr[i];
    
    MergeSort(left);
    MergeSort(right);
    
    Merge(arr, left, right);

    void Merge(int[] ints, int[] left1, int[] right1)
    {
        int l = 0, r = 0, k = 0;
        
        while (l < left1.Length && r < right1.Length)
        {
            if (left1[l] <= right1[r])
            {
                ints[k] = left1[l];
                l++;
            }
            else
            {
                ints[k] = right1[r];
                r++;
            }
            k++;
        }
        
        while (l < left1.Length)
        {
            ints[k] = left1[l];
            l++;
            k++;
        }
        
        while (r < right1.Length)
        {
            ints[k] = right1[r];
            r++;
            k++;
        }
    }
}