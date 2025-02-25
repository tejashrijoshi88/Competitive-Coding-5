// time complexity - O(n)
// space complexity - O(1)
// Approach - We will check the element is not repeated in any row and in any column with tow for loops
// And to check if it is not repeated in box, we will take a extra two for loops to set i and j value 

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        if (board == null || board.Length != 9 || board[0].Length != 9)
        {
            return false;
        }
        int n = board.Length;
        int m = board[0].Length;
        HashSet<char> set = new HashSet<char>();

        // to check element not repeated in row
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] != '.')
                {
                    if (set.Contains(board[i][j]))
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine(board[i][j]);
                        set.Add(board[i][j]);
                    }
                }
            }
            set.Clear();
        }

        // to check element not repeated in column
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("init " + board[i][j]);
                if (board[i][j] != '.')
                {
                    if (set.Contains(board[i][j]))
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine(board[i][j]);
                        set.Add(board[i][j]);
                    }
                }
            }
            set.Clear();
        }
        // // to check element not repeated in 3*3 box
        for (int l = 0; l < 9; l = l + 3)
        {
            for (int k = 0; k < 9; k = k + 3)
            {
                for (int i = l; i < l + 3; i++)
                {
                    for (int j = k; j < k + 3; j++)
                    {
                        if (board[i][j] != '.')
                        {
                            if (set.Contains(board[i][j]))
                            {
                                return false;
                            }
                            else
                            {
                                set.Add(board[i][j]);
                            }
                        }
                    }
                }
                set.Clear();
            }
        }
        return true;
    }
}