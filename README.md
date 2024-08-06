# Sudoku Solver

This is a Windows Forms application for solving classic 9x9 Sudoku puzzles using the .NET Framework 4+. It allows users to manually enter Sudoku puzzles, solve them, and save/load puzzles from files.

## Features

- Manually enter Sudoku puzzles into a 9x9 grid.
- Solve the entered Sudoku puzzle.
- Save and load Sudoku puzzles to/from files.

## Technologies Used

- .NET Framework 4+
- Windows Forms
- C#

## Getting Started

### Prerequisites

- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)

### Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/yourusername/SudokuSolver.git
   cd SudokuSolver
2. Build the project:

`
dotnet build`
3. Run the project:
`
dotnet run --project SudokuSolver`
4. Usage
## Enter the Puzzle:

## Open the application.
### Enter the Sudoku puzzle into the 9x9 grid. Use 0 for empty cells.
### Solve the Puzzle:

Click the "Solve" button to solve the puzzle.
### Save the Puzzle:

Click the "Save" button to save the current state of the puzzle to a file.
### Load the Puzzle:

Click the "Load" button to load a saved puzzle file into the grid.
### Example
Sample Sudoku Puzzle
```sh
5 3 0 | 0 7 0 | 0 0 0
6 0 0 | 1 9 5 | 0 0 0
0 9 8 | 0 0 0 | 0 6 0
------+------+------
8 0 0 | 0 6 0 | 0 0 3
4 0 0 | 8 0 3 | 0 0 1
7 0 0 | 0 2 0 | 0 0 6
------+------+------
0 6 0 | 0 0 0 | 2 8 0
0 0 0 | 4 1 9 | 0 0 5
0 0 0 | 0 8 0 | 0 7 9
```
```sh
Solution to the Puzzle



5 3 4 | 6 7 8 | 9 1 2
6 7 2 | 1 9 5 | 3 4 8
1 9 8 | 3 4 2 | 5 6 7
------+------+------
8 5 9 | 7 6 1 | 4 2 3
4 2 6 | 8 5 3 | 7 9 1
7 1 3 | 9 2 4 | 8 5 6
------+------+------
9 6 1 | 5 3 7 | 2 8 4
2 8 7 | 4 1 9 | 6 3 5
3 4 5 | 2 8 6 | 1 7 9
```
## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Contributing
Contributions are welcome! Please feel free to submit a Pull Request.
