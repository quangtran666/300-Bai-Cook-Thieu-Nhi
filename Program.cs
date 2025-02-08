var nums1 = new int[] { 0 };

var nums2 = new int[] { 1 };

Merge(nums1, 0, nums2, 1);

Console.WriteLine(string.Join(", ", nums1));

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    var i = m - 1;
    var j = n - 1;
    var k = m + n - 1;

    while (j >= 0)
    {
        if (i >= 0 && nums1[i] > nums2[j])
        {
            nums1[k] = nums1[j];
            i--;
        }
        else
        {
            nums1[k] = nums2[j];
            j--;
        }
        
        k--;
    }
}