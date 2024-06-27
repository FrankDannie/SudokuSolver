using System;
using System.IO;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        private TextBox[,] textBoxes = new TextBox[9, 9];

        public Form1()
        {
            InitializeComponent();
            InitializeSudokuGrid();
        }

        private void InitializeSudokuGrid()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    textBoxes[row, col] = new TextBox
                    {
                        Width = 30,
                        Height = 30,
                        Location = new System.Drawing.Point(30 * col, 30 * row),
                        TextAlign = HorizontalAlignment.Center,
                        MaxLength = 1
                    };
                    this.Controls.Add(textBoxes[row, col]);
                }
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            int[,] board = new int[9, 9];
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    board[row, col] = string.IsNullOrEmpty(textBoxes[row, col].Text) ? 0 : int.Parse(textBoxes[row, col].Text);
                }
            }

            SudokuSolver solver = new SudokuSolver();
            if (solver.Solve(board))
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        textBoxes[row, col].Text = board[row, col].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No solution exists");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SavePuzzle(saveFileDialog.FileName);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadPuzzle(openFileDialog.FileName);
            }
        }

        private void SavePuzzle(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        writer.Write(textBoxes[row, col].Text + " ");
                    }
                    writer.WriteLine();
                }
            }
        }

        private void LoadPuzzle(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                for (int row = 0; row < 9; row++)
                {
                    string[] line = reader.ReadLine().Split(' ');
                    for (int col = 0; col < 9; col++)
                    {
                        textBoxes[row, col].Text = line[col];
                    }
                }
            }
        }
    }
}
