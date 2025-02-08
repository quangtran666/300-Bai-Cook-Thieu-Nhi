var nums1 = new int[] { 4,5,6,0,0,0 };

var nums2 = new int[] { 1, 2, 3 };

Merge(nums1, 3, nums2, 3);

Console.WriteLine(string.Join(", ", nums1));

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    for (int i = 0; i < n; i++)
    {
        nums1[m + i] = nums2[i];
    }
    
    Array.Sort(nums1);
}