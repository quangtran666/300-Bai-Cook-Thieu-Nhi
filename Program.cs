var nums = new int[] { 0,0,1,1,1,2,2,3,3,4 };

var result = RemoveDuplicates(nums);

Console.WriteLine(result);
Console.WriteLine(string.Join(", ", nums));

int RemoveDuplicates(int[] nums)
{
    var left = 0;
    var count = 1;

    for (var i = 1; i < nums.Length; i++)
    {
        if (nums[i] == nums[left])
        {
            continue;
        }
        else
        {
            nums[left + 1] = nums[i];
            count++;
            left++;
        }
    }
    
    return count;
}