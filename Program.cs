var nums = new int[] { 3,2,2,3 };
Console.WriteLine(RemoveElement(nums, 2));

Console.WriteLine(string.Join(", ", nums));

int RemoveElement(int[] nums, int val)
{
    var pointer = 0;
    var result = 0;

    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            result++;
            nums[pointer] = nums[i];
            pointer++;
        }
    }
    
    return result;
}