var intervals = new int[][] {
    [1, 3],
    [2, 6],
    [8, 10],
    [15, 18]
};

var result = Merge(intervals);

foreach (var interval in result)
{
    Console.WriteLine($"[{interval[0]}, {interval[1]}]");
}

int[][] Merge(int[][] intervals) {
    Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
    var result = new List<int[]>();

    foreach (var interval in intervals)
    {
        if (result.Count == 0 || interval[0] > result.Last()[1]) 
            result.Add(interval);
        else
            result.Last()[1] = Math.Max(interval[1], result.Last()[1]);
    }
    
    return result.ToArray();
}