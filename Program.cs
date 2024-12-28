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
    var dictRow = new Dictionary<int, HashSet<char>>();
    var dictCol = new Dictionary<int, HashSet<char>>();
    var dictBox = new Dictionary<int, HashSet<char>>();
    
    for (var horizontal = 0; horizontal < board.Length; horizontal++)
    {
        dictRow[horizontal] = [];
        for (var vertical = 0; vertical < board[horizontal].Length; vertical++)
        {
            if (!dictCol.ContainsKey(vertical))
            {
                dictCol[vertical] = [];
            }
            
            if (board[horizontal][vertical] == '.') continue;

            if (dictRow[horizontal].Contains(board[horizontal][vertical]))
                return false;
            dictRow[horizontal].Add(board[horizontal][vertical]);

            if (dictCol[vertical].Contains(board[horizontal][vertical]))
                return false;
            dictCol[vertical].Add(board[horizontal][vertical]);
        }
    }

    int verticalStart = 0;
    int horizontalStart;
    int currentBox = 0;
    dictBox[currentBox] = [];
    
    for (horizontalStart = 0; horizontalStart < board.Length; )
    {
        int maxVerticalStart = verticalStart + 3;
        while (verticalStart < maxVerticalStart)
        {
            if (board[horizontalStart][verticalStart] == '.')
            {
                verticalStart++;
                continue;
            }
            
            if (dictBox[currentBox].Contains(board[horizontalStart][verticalStart]))
                return false;
            dictBox[currentBox].Add(board[horizontalStart][verticalStart]);
            verticalStart++;
        }

        horizontalStart++;
        
        if (horizontalStart == 9 && verticalStart == 9) 
                    break;
        if (horizontalStart % 3 == 0 && verticalStart == maxVerticalStart && horizontalStart != 0)
        {
            currentBox++;
            dictBox[currentBox] = [];
        }
        
        verticalStart = maxVerticalStart - 3;
        
        if (horizontalStart == 9)
        {
            verticalStart = maxVerticalStart;
            horizontalStart = 0;
        }
    }

    return true;
}