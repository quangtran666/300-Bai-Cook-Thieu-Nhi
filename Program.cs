var nums = new int[] {1,3};

var target = 3;

Console.WriteLine(Search(nums, target));

int Search(int[] nums, int target)
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

    if (left == 0)
    {
        left = 0;
        right = nums.Length - 1;
    } 
    else if (target >= nums[0] && nums[left] < target)
    {
        right = left - 1;
        left = 0;
    }
    else
    {
        left = left;
        right = nums.Length - 1;
    }
    
    while (left <= right)
    {
        var mid = (left + right) / 2;
        if (nums[mid] > target)
        {
            right = mid - 1;
        }
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            return mid;
        }
    }

    return -1;
}