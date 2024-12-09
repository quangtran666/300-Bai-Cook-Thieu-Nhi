int[] nums = [1,1,1,2,2,3];

var result = TopKFrequent(nums, 2);

foreach (var item in result)
{
    Console.WriteLine(item);
}

int[] TopKFrequent(int[] nums, int k) {
    var dict = new Dictionary<int, int>();   

    foreach (var num in nums) {
        dict[num] = dict.GetValueOrDefault(num, 0) + 1;
    }

    return dict
            .OrderByDescending(x => x.Value)
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
}   