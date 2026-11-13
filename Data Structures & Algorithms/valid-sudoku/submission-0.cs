public class Solution {
    public bool IsValidSudoku(char[][] board) 
      {
    var rowHashs = new HashSet<int>[board.Length];
    var colHashs = new HashSet<int>[board.Length];
    var subBoxHashs = new HashSet<int>[board.Length];

    for (int i = 0; i < board.Length; i++)
    {
      rowHashs[i] = new HashSet<int>();
      colHashs[i] = new HashSet<int>();
      subBoxHashs[i] = new HashSet<int>();
    }

    for (int i = 0; i < board.Length; i++)
    {
      for (int j = 0; j < board[i].Length; j++)
      {
        if (board[i][j] == '.') continue;

        if (false == rowHashs[i].Add(board[i][j])) return false;
        if (false == colHashs[j].Add(board[i][j])) return false;
        var box_idx = (j < 3 ? 0 : (j / 3))
          + (i < 3 ? 0 : (i/3)* 3);
        if (false == subBoxHashs[box_idx].Add(board[i][j])) return false;
      }
    }
    return true;
  }

}
