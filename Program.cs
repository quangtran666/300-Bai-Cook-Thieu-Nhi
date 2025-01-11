int[] nums = [3, 4, 5, 1, 2];

var result = FindMin(nums);
Console.WriteLine(result);

int FindMin(int[] nums)
{
    var left = 0;
    var right = nums.Length - 1;

    while (left < right)
    {
        var mid = (left + right) / 2;
        if (nums[mid] > nums[right])
        {
            left = mid + 1;
        }
        else
        {
            right = mid;
        }
    }

    return nums[left];
}