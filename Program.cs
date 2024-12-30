var nums = new int[] { -1, 0, 1, 2, -1, -4 };

var result = ThreeSum(nums);

IList<IList<int>> ThreeSum(int[] nums)
{
    Array.Sort(nums);
    IList<IList<int>> result = new List<IList<int>>();

    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0) break;
        if (i > 0 && nums[i] == nums[i - 1]) continue;

        int l = i + 1, r = nums.Length - 1;
        while (l < r)
        {
            var sum = nums[i] + nums[l] + nums[r];
            if (sum > 0)
            {
                r--;
            }
            else if (sum < 0)
            {
                l++;
            }
            else
            {
                result.Add(new List<int> { nums[i], nums[l], nums[r] });
                l++;
                r--;
                while (l < r && nums[l] == nums[l - 1])
                {
                    l++;
                }
            }
        }
    }

    return result;
}