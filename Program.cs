int[] nums = [3, 2, 3];

Console.Write(MajorityElement(nums));

int MajorityElement(int[] nums)
{
    var dictionary = new Dictionary<int, int>();

    foreach (var num in nums)
    {
        dictionary[num] = dictionary.GetValueOrDefault(num, 1) + 1;
    }

    return dictionary
        .First(x => x.Value == dictionary.Values.Max())
        .Key;
}