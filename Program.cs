var board = new char[][] 
{
    ['5','3','.','.','7','.','.','.','.'],
    ['6','.','.','1','9','5','.','.','.'],
    ['.','9','8','.','.','.','.','6','.'],
    ['8','.','.','.','6','.','.','.','3'],
    ['4','.','.','8','.','3','.','.','1'],
    ['7','.','.','.','2','.','.','.','6'],
    ['.','6','.','.','.','.','2','8','.'],
    ['.','.','.','4','1','9','.','.','5'],
    ['.','.','.','.','8','.','.','7','9']
};

var result = IsValidSudoku(board);

Console.WriteLine(result);

bool IsValidSudoku(char[][] board)
{
    var rows = new Dictionary<int, HashSet<int>>();
    var cols = new Dictionary<int, HashSet<int>>();
    var boxes = new Dictionary<string, HashSet<int>>();

    for (var r = 0; r < 9; r++)
    {
        for (var c = 0; c < 9; c++)
        {
            if (board[r][c] == '.') continue;

            var boxesKey = (r / 3) + "," + (c / 3);

            if (rows.ContainsKey(r) && rows[r].Contains(board[r][c]) ||
                cols.ContainsKey(c) && cols[c].Contains(board[r][c]) ||
                boxes.ContainsKey(boxesKey) && boxes[boxesKey].Contains(board[r][c]))
                return false;

            if (!rows.ContainsKey(r)) rows[r] = [];
            if (!cols.ContainsKey(c)) cols[c] = [];
            if (!boxes.ContainsKey(boxesKey)) boxes[boxesKey] = [];
            
            rows[r].Add(board[r][c]);
            cols[c].Add(board[r][c]);
            boxes[boxesKey].Add(board[r][c]);
        }
    }

    return true;
}