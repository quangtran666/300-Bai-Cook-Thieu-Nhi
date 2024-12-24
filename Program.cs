int[] input = [1, 2, 3, 4];

var result = ProductExceptSelf(input);
foreach (var i in result)
{
    Console.WriteLine(i);
}

int[] ProductExceptSelf(int[] nums) {
    var left = new int[nums.Length];
    var right = new int[nums.Length];
    var leftMulti = 1;
    var rightMulti = 1;

    for (int i = 0; i < nums.Length; i++)
    {
        if (i == 0)
        {
            left[0] = 1;
            continue;
        }
        
        leftMulti *= nums[i - 1];
        left[i] = leftMulti;
    }

    for (int i = nums.Length - 1; i >= 0; i--)
    {
        if (i == nums.Length - 1)
        {
            right[nums.Length - 1] = 1;
            continue;
        }

        rightMulti *= nums[i + 1];
        right[i] = rightMulti;
    }
    
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = left[i] * right[i];
    }
    
    return nums;
}