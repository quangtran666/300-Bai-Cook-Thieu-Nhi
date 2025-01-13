int[] nums = [-1, 1, 2, 3, 1];

const int target = 2;

Console.WriteLine(CountPairs(nums, target));

int CountPairs(IList<int> nums, int target)
{
    var numsSort = nums.OrderBy(x => x).ToList();
    var left = 0;
    var right = nums.Count - 1;
    var count = 0;

    while (left < right)
    {
        if (numsSort[left] + numsSort[right] < target)
        {
            count += right - left;
            left++;
        }
        else
        {
            right--;
        }
    }

    return count;
}