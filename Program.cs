int MissingNumber(int[] nums)
{
    var hashset = new HashSet<int>(nums);

    for (var i = 0; i <= nums.Length; i++)
    {
        if (!hashset.Contains(i))
            return i;
    }

    return 0;
}