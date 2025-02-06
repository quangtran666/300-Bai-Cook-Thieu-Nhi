var nums = new int[] { 1, 2, 1 };

var result = GetConcatenation(nums);
Console.WriteLine(string.Join(", ", result));

int[] GetConcatenation(int[] nums)
{
    var result = new int[nums.Length * 2];

    for (var i = 0; i < nums.Length; i++)
    {
        result[i] = nums[i];
        result[i + nums.Length] = nums[i];
    }
    
    return result;
}