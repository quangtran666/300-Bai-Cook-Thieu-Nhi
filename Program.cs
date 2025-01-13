int[] nums = [-1, 1, 2, 3, 1];

const int target = 2;

Console.WriteLine(CountPairs(nums, target));

int CountPairs(IList<int> nums, int target) {
    var count = 0;
    
    for (var x = 0; x < nums.Count; x++) {
        for (var y = x + 1; y < nums.Count; y++)
        {
            if (x < y && (nums[x] + nums[y] < target))
                count++;
        }
    }
    
    return count;
}