int[] nums = [1,2,3,1];

var result = ContainsDuplicate(nums);

Console.WriteLine(result);

bool ContainsDuplicate(int[] nums) {
    HashSet<int> hashset = [];

    foreach (var num in nums) {
        if (hashset.TryGetValue(num, out var actualNum)) 
            return true;
        hashset.Add(num);
    }

    return false;
}