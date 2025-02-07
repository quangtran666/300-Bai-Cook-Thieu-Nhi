var nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

Console.WriteLine(string.Join(", ", FindDisappearedNumbers(nums)));

IList<int> FindDisappearedNumbers(int[] nums) {
    var hashset = new HashSet<int>(nums);
    var list = new List<int>();

    for (int i = 1; i <= nums.Length; i++)
    {
        if (!hashset.Contains(i))
            list.Add(i);
    }

    return list;
}