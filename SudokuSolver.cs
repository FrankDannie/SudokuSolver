namespace SudokuSolver
{
    public class SudokuSolver
    {
        public bool Solve(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsSafe(board, row, col, num))
                            {
                                board[row, col] = num;

                                if (Solve(board))
                                {
                                    return true;
                                }

                                board[row, col] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsSafe(int[,] board, int row, int col, int num)
        {
            for (int x = 0; x < 9; x++)
            {
                if (board[row, x] == num || board[x, col] == num ||
                    board[row - row % 3 + x / 3, col - col % 3 + x % 3] == num)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
