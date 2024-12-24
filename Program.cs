var input = new int[] { 100, 4, 200, 1, 3, 2 };

var result = LongestConsecutive(input);

Console.WriteLine(result);

int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0) return 0;
    
    var numHashset = nums.ToHashSet();
    var longestStreak = 1;

    foreach (var num in numHashset)
    {
        var currentNum = num;
        var streak = 1;

        if (numHashset.Contains(num - 1)) continue;
        
        while (numHashset.Contains(currentNum + 1))
        {
            streak++;
            currentNum += 1;
        }
        
        longestStreak = longestStreak < streak ? streak : longestStreak;
    }

    return longestStreak;
}