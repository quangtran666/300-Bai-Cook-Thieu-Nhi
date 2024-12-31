var height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

var result = Trap(height);
Console.WriteLine(result);

int Trap(int[] height)
{
    var maxLeft = new int[height.Length];
    var maxRight = new int[height.Length];
    var totalTrapWater = 0;
    
    maxLeft[0] = 0;
    maxRight[height.Length - 1] = 0;

    for (var i = 1; i < height.Length; i++)
    {
        var maxLeftHeight = 0;
        for (var j = i - 1; j >= 0; j--)
        {
            maxLeftHeight = Math.Max(maxLeftHeight, height[j]);
        }
        maxLeft[i] = maxLeftHeight;
    }

    for (var i = height.Length - 2; i >= 0; i--)
    {
        var maxRightHeight = 0;
        for (var j = i + 1; j < height.Length; j++)
        {
            maxRightHeight = Math.Max(maxRightHeight, height[j]);
        }
        maxRight[i] = maxRightHeight;
    }

    for (var i = 1; i < height.Length - 1; i++)
    {
        var trapWater = Math.Min(maxLeft[i], maxRight[i]) - height[i];
        totalTrapWater += Math.Max(trapWater, 0);
    }

    return totalTrapWater;
}