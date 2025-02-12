var arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };

BubbleSort(arr);

Console.Write(string.Join(", ", arr));
 
void BubbleSort(int[] arr)
 {
     var swapped = true;

     while (swapped)
     {
         swapped = false;
         for (var i = 0; i < arr.Length - 1; i++)
         {
             if (arr[i + 1] < arr[i])
             {
                 swapped = true;
                 (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
             }   
         }    
     }
 }