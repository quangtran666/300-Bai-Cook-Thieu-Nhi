int[][] matrix = [[1]];
var target = 1;

Console.WriteLine(SearchMatrix(matrix, target));

bool SearchMatrix(int[][] matrix, int target)
{
    var rowsLength = matrix.Length;
    var colsLength = matrix[0].Length;

    var top = 0;
    var bottom = rowsLength - 1;
    var row = 0;

    while (top <= bottom)
    {
        row = (top + bottom) / 2;
        if (target < matrix[row][0])
            bottom = row - 1;
        else if (target > matrix[row][colsLength - 1])
            top = row + 1;
        else
            break;
    }

    var left = 0;
    var right = colsLength - 1;
    
    while (left < right)
    {
        var mid = (left + right) / 2;

        if (matrix[row][mid] == target)
            return true;

        if (matrix[row][mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return false;
}