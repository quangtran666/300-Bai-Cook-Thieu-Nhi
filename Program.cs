var height = new int[] {1,8,6,2,5,4,8,3,7};

var result = MaxArea(height);
Console.WriteLine(result);

int MaxArea(int[] height)
{
    var maxWater = 0;
    int left = 0, right = height.Length - 1;

    while (left < right)
    {
        var area = Math.Min(height[left], height[right]) * (right - left);
        maxWater = Math.Max(area, maxWater);

        if (height[left] <= height[right])
            left++;
        else
            right--;
    }
    
    return maxWater;
}
