int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var target = 6;

Console.WriteLine(BinarySearch(nums, target));

int BinarySearch(int[] nums, int target)
{
    var left = 0;
    var right = nums.Length - 1;

    while (left <= right)
    {
        var mid = (left + right) / 2;
        if (mid == target)
            return mid;
        else if (mid > target)
            right = mid - 1;
        else
            left = mid + 1;
    }

    return -1;
}