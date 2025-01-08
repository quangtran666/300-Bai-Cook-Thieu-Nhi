List<int> ranked = [100, 90, 90, 80];
List<int> player = [70, 80, 105];

var result = climbingLeaderboard(ranked, player);

List<int> climbingLeaderboard(List<int> ranked, List<int> player)
{
    var monotonicStack = new Stack<int>();
    var currentRank = 1;
    var result = new int[player.Count];

    for (var rank = ranked.Count - 1; rank >= 0; rank--)
    {
        if (monotonicStack.Count != 0 && monotonicStack.Peek() == ranked[rank])
            continue;
        monotonicStack.Push(ranked[rank]);
    }

    for (var x = player.Count - 1; x >= 0; x--)
    {
        while (monotonicStack.Count != 0 && player[x] < monotonicStack.Peek())
        {
            monotonicStack.Pop();
            currentRank++;
        }

        result[x] = currentRank;
    }

    return result.ToList();
}