var numbers = new int[] { 2, 7, 11, 15 };
var target = 9;

var result = TwoSum(numbers, target);
foreach (var i in result)
{
   Console.WriteLine(i);
}

int[] TwoSum(int[] numbers, int target)
{
   int left = 0, right = numbers.Length - 1;

   while (left != right)
   {
      if (numbers[left] + numbers[right] == target)
         return [left + 1, right + 1];
      
      if (numbers[left] + numbers[right] < target)
         left++;
      else if (numbers[left] + numbers[right] > target)
         right--;
   }

   return [];
}