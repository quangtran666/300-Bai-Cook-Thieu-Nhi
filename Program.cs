var prices = new int[] {7,1,5,3,6,4};

Console.WriteLine(MaxProfit(prices));

int MaxProfit(int[] prices)
{
    int start = 0, end = 0, max = 0;
    
    for (var i = 1; i < prices.Length; i++)
    {
        if (prices[i] < prices[start])
        {
            start = i;
        }

        end = i;
        
        max = Math.Max(max, prices[end] - prices[start]);
    }

    return max;
}