int[] nums1 = [1, 2, 2, 1];
int[] nums2 = [2, 2];

Console.Write(string.Join(" ", Intersection(nums1, nums2)));

int[] Intersection(int[] nums1, int[] nums2)
{
    var hashset1 = new HashSet<int>(nums1);
    var hashset2 = new HashSet<int>(nums2);

    return hashset1.Intersect(hashset2).ToArray();
}