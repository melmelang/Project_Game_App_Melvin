CREATE TABLE [dbo].[Player] (
    [PlayerId]    INT           IDENTITY (1, 1) NOT NULL,
    [UserName]    NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NOT NULL,
    [TicTacToeId] INT           NULL,
    [SudokuId]    INT           NULL,
    PRIMARY KEY CLUSTERED ([PlayerId] ASC),
    CONSTRAINT [FK_TicTacToe] FOREIGN KEY ([TicTacToeId]) REFERENCES [dbo].[TicTacToe] ([TicTacToeId]),
    CONSTRAINT [FK_Sudoku] FOREIGN KEY ([SudokuId]) REFERENCES [dbo].[Sudoku] ([SudokuId])
);

