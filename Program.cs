var nums = new int[] {1,12,-5,-6,50,3 };

var k = 4;

Console.WriteLine(FindMaxAverage(nums, k));

double FindMaxAverage(int[] nums, int k)
{
    var average = double.MinValue;
    var left = 0;
    var total = 0;

    for (var i = 0; i < nums.Length; i++)
    {
        total += nums[i];
        if (i - left + 1 < k)
        {
            continue;
        };
        average = Math.Max(average, total * 1.0 / k);
        total -= nums[left];
        left++;
    }
    
    return average;
}