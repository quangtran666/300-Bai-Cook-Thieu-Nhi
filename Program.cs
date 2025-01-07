int[] nums = [2, 1, 3, 2, 4, 3];

foreach (var element in NextSmallerElements(nums))
{
    Console.WriteLine(element);
}

int[] NextSmallerElements(int[] nums)
{
    var monotonicStack = new Stack<int>();
    var result = new int[nums.Length];
    Array.Fill(result, -1);

    for (var x = 0; x < nums.Length; x++)
    {
        while (monotonicStack.Any() && nums[x] < nums[monotonicStack.Peek()])
        {
            result[monotonicStack.Pop()] = nums[x];
        } 
        monotonicStack.Push(x);
    }

    return result;
}