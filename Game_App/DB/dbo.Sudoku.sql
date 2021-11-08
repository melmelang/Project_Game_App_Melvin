CREATE TABLE [dbo].[Sudoku] (
    [SudokuId] INT          IDENTITY (1, 1) NOT NULL,
    [Score]    VARCHAR (50) NOT NULL,
	[Difficulty] INT NOT NULL, 
    [PlayerId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([SudokuId] ASC),
    CONSTRAINT [PlayerSudoku] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([PlayerId])
);

