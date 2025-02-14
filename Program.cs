var intervals = new int[][] {
    [1, 2],
    [2, 3],
    [3, 4],
    [1, 3]
};

var result = EraseOverlapIntervals(intervals);

Console.WriteLine(result);

int EraseOverlapIntervals(int[][] intervals)
{
    Array.Sort(intervals, (a, b) => a[1] - b[1]);
    var count = 1;
    var end = intervals[0][1];
    
    for (var i = 1; i < intervals.Length; i++)
    {
        if (intervals[i][0] >= end)
        {
            count++;
            end = intervals[i][1];
        }
    }

    return intervals.Length - count;
}