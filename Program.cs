var code = new int[] { 5, 7, 1, 4 };

var k = 3;

Console.WriteLine(string.Join(", ", Decrypt(code, k)));

int[] Decrypt(int[] code, int k)
{
    var result = new int[code.Length];

    for (var i = 0; i < code.Length; i++)
    {
        switch (k)
        {
            case > 0:
            {
                var count = 1;
                while (count <= k)
                {
                    result[i] += code[(i + count) % code.Length];
                    count++;
                }

                break;
            }
            case < 0:
            {
                var count = 1;
                while (count <= Math.Abs(k))
                {
                    result[i] += code[(i - count + code.Length) % code.Length];
                    count++;
                }

                break;
            }
            default:
                result[i] = 0;
                break;
        }
    }
    
    return result;
}