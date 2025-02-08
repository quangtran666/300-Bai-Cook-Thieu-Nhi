var s = new char[] { 'h', 'e', 'l', 'l', 'o' };

ReverseString(s);

Console.WriteLine(s);

void ReverseString(char[] s) {
    var left = 0;
    var right = s.Length - 1;

    while (left < right)
    {
        (s[left], s[right]) = (s[right], s[left]);
        left++;
        right--;
    }
}