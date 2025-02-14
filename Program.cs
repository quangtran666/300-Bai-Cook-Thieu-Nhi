var intervals = new List<int[]> { new int[] { 0, 1 }, new int[] { 2, 4 }, new int[] { 1, 3 }, new int[] { 5, 6 } };

Console.WriteLine(CanAttendMeetings(intervals));

bool CanAttendMeetings(List<int[]> intervals)
{
    intervals.Sort((a, b) => a[0] - b[0]);

    for (var i = 1; i < intervals.Count; i++)
    {
        if (intervals[i][0] < intervals[i - 1][1])
            return false;
    }
    
    return true;
}