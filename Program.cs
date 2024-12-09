int[] nums = [3, 3];

var result = TwoSum(nums, 6);

Console.WriteLine(result[0] + " " + result[1]);

int[] TwoSum(int[] nums, int target) {
    var dict = new Dictionary<int, int>();
    int[] result = [];

    for (var i = 0; i < nums.Length; i++) {
        if (dict.TryGetValue(target - nums[i], out var actualValue)) {
            result = [actualValue, i];
        }

        dict.TryAdd(nums[i], i);
    }

    return result;
}