CREATE TABLE [dbo].[Sudoku] (
    [SudokuId] INT          IDENTITY (1, 1) NOT NULL,
    [Score]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([SudokuId] ASC)
);

