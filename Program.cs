var height = new int[] {1,8,6,2,5,4,8,3,7};

var result = MaxArea(height);
Console.WriteLine(result);
 
int MaxArea(int[] height) {
    int left = 0, right = height.Length - 1;
    int water = 0;

    while (left < right) {
        int minHeight = height[left] < height[right] ? left : right;

        water = (right - left) * height[minHeight] > water ? (right - left) * height[minHeight] : water;

        if (minHeight == left)
            left++;
        else 
            right--;            
    }

    return water;
}